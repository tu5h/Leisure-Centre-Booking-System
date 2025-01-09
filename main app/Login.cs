using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace NEA___D1
{
    public partial class Login : BaseForm
    {
        public static int CurrentUserId { get; private set; }

        public Login()
        {
            InitializeComponent();
            LeftSideBarPanel.Visible = false;
            topLeftIconPanel.Visible = false;

            SetPlaceholder(UsernameTxtBox, "ENTER USERNAME");
            SetPlaceholder(PasswordTxtBox, "ENTER PASSWORD");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        //routine to validate details entered
        private void button1_Click(object sender, EventArgs e)
        {
            //username and password control data validation
            if (string.IsNullOrEmpty(UsernameTxtBox.Text) || string.IsNullOrEmpty(PasswordTxtBox.Text))
            {
                MessageBox.Show("Please enter both username and password.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //call authenticateUser  routine
            bool isAuthenticated = AuthenticateUser(UsernameTxtBox.Text, PasswordTxtBox.Text);

            if (isAuthenticated)
            {
                //determine user priority for access control required for features and menus
                CurrentUserId = GetUserIdByUsername(UsernameTxtBox.Text);
                int priorityLevel = GetPriorityLevelByUserId(CurrentUserId);
                if (priorityLevel == 5)
                {
                    AdminDash adminForm = new AdminDash();
                    adminForm.Show();
                    PasswordTxtBox.Clear();
                    Dashboard dboard = new Dashboard();
                    this.Hide();
                    dboard.Show();
                }
                else
                {                    
                    PasswordTxtBox.Clear();
                    Dashboard dboard = new Dashboard();
                    this.Hide();
                    dboard.Show();
                    errorLabel.Visible = false;
                    incorrectLabel.Visible = false;
                }
            }
            else
            {
                getGoingTxt.Visible = false;
                errorLabel.Visible = true;
                incorrectLabel.Visible = true;
            }
        }

        //function to retieve userId from login table by supplying the username. 
        private int GetUserIdByUsername(string username)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT LoginID FROM login WHERE Username = @Username";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Username", username);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        //exit and close application
        private void Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit(); // Exit
        }

        private void UsernameTxtBox_TextChanged(object sender, EventArgs e)
        {
        }

        //routine to call and display new sign-up form when the sign-up button is clicked
        private void signUpButton_Click(object sender, EventArgs e)
        {
            Signup signUp = new Signup(); // Sign up form
            this.Hide();
            signUp.Show();
        }

        //Authenticate user credentials
        private bool AuthenticateUser(string username, string password)
        {
            List<UserCredential> userCredentials = RetrieveUserCredentialsFromDatabase();
            foreach (var credential in userCredentials)
            {
                if (credential.Username == username)
                {
                    return VerifyPassword(password, credential.Password);
                }
            }
            return false;
        }

        //Retrieve crendtials from login table
        private List<UserCredential> RetrieveUserCredentialsFromDatabase()
        {
            List<UserCredential> userCredentials = new List<UserCredential>();
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Username, Password FROM login";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                userCredentials.Add(new UserCredential(reader.GetString("Username"), reader.GetString("Password")));
                            }
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return userCredentials;
        }

        //Verify password by using Hashing algorithm
        private bool VerifyPassword(string inputPassword, string hashedPassword)
        {
            // Hashing logic
            byte[] salt = Encoding.UTF8.GetBytes("23"); // Salt value
            using (var hmac = new System.Security.Cryptography.HMACSHA256(salt))   //Using SHA 256 algorithm for hashing
            {
                byte[] hashBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(inputPassword));
                string hashedInputPassword = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                return hashedInputPassword == hashedPassword;
            }
        }

        //Determine user type, admin or user
        private int GetPriorityLevelByUserId(int userId)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT PriorityLevel FROM userroles WHERE LoginID = @UserId";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        //New class for user credentials
        public class UserCredential
        {
            public string Username { get; set; }
            public string Password { get; set; }

            public UserCredential(string username, string password)
            {
                Username = username;
                Password = password;
            }
        }
    }
}

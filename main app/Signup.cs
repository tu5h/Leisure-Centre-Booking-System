using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace NEA___D1
{
    public partial class Signup : BaseForm
    {
        List<Panel> listpanel = new List<Panel>();
        int index;

        public Signup()
        {
            InitializeComponent();

            firstPagePanel.BackColor = BackgroundColor;
            secondPagePanel.BackColor = BackgroundColor;
            thirdPagePanel.BackColor = BackgroundColor;
            LeftSideBarPanel.Visible = false;
            topLeftIconPanel.Visible = false;



            SetPlaceholder(firstnameTxtBox, "ENTER FIRSTNAME");
            SetPlaceholder(lastnameTxtBox, "ENTER LASTNAME");
            SetPlaceholder(passwordTxtBox, "ENTER PASSWORD");
            SetPlaceholder(confirmpasswordTxtBox, "CONFIRM PASSWORD");
            SetPlaceholder(emailTxtBox, "ENTER EMAIL ADDRESS");
            SetPlaceholder(phoneNumTxtBox, "ENTER PHONE NUMBER");
            SetPlaceholder(usenameTxtBox, "ENTER USERNAME");
            SetPlaceholder(houseaddressTxtBox, "ENTER HOUSE ADDRESS");
            SetPlaceholder(addressTxtBox, "...ADDRESS LINE 2");
            SetPlaceholder(townTxtBox, "ENTER TOWN");
            SetPlaceholder(countyTxtBox, "ENTER COUNTY");
            SetPlaceholder(postcodeTxtBox, "ENTER POSTCODE");

            listpanel.Add(firstPagePanel);
            listpanel.Add(secondPagePanel);
            listpanel.Add(thirdPagePanel);
            listpanel[index].BringToFront();
        }

        private void Signup_Load(object sender, EventArgs e)
        {
            listpanel.Add(firstPagePanel);
            listpanel.Add(secondPagePanel);
            listpanel.Add(thirdPagePanel);
            listpanel[index].BringToFront();
        }

        private void nextButton_Click(object sender, EventArgs e)
        {
            if (index < listpanel.Count - 1)
            {
                listpanel[++index].BringToFront();
            }
        }

        private void previousButton_Click(object sender, EventArgs e)
        {
            if (index > 0)
            {
                listpanel[--index].BringToFront();
            }
        }

        private void gobackButton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void continueButton_Click(object sender, EventArgs e)
        {
            if (passwordTxtBox.Text != confirmpasswordTxtBox.Text)
            {
                MessageBox.Show("Passwords do not match. Please try again.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            //string salt = "23";
            string hashedPassword = HashPassword(passwordTxtBox.Text);//, salt);

            if (SaveUserToDatabase(firstnameTxtBox.Text, lastnameTxtBox.Text, emailTxtBox.Text, phoneNumTxtBox.Text, hashedPassword, usenameTxtBox.Text, houseaddressTxtBox.Text, addressTxtBox.Text, townTxtBox.Text, countyTxtBox.Text, postcodeTxtBox.Text))
            {
                MessageBox.Show("Successfully created account!");
                Login login = new Login();
                this.Hide();
                login.Show();
            }
            else
            {
                MessageBox.Show("An error occurred while saving the user data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool SaveUserToDatabase(string firstName, string lastName, string email, string phoneNumber, string hashedPassword, string username, string houseAddress, string addressLine2, string town, string county, string postcode)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    // Insert data into the Users table
                    string insertUserQuery = "INSERT INTO users (FirstName, LastName, Email, PhoneNumber) " +
                        "VALUES (@FirstName, @LastName, @Email, @PhoneNumber);";
                    MySqlCommand userCommand = new MySqlCommand(insertUserQuery, conn);
                    userCommand.Parameters.AddWithValue("@FirstName", firstName);
                    userCommand.Parameters.AddWithValue("@LastName", lastName);
                    userCommand.Parameters.AddWithValue("@Email", email);
                    userCommand.Parameters.AddWithValue("@PhoneNumber", phoneNumber);
                    userCommand.ExecuteNonQuery();

                    int lastUserId = (int)userCommand.LastInsertedId;

                    string insertLoginQuery = "INSERT INTO login (Username, Password) " +
                        "VALUES (@Username, @Password);";
                    MySqlCommand loginCommand = new MySqlCommand(insertLoginQuery, conn);
                    loginCommand.Parameters.AddWithValue("@Username", username);
                    loginCommand.Parameters.AddWithValue("@Password", hashedPassword);
                    loginCommand.ExecuteNonQuery();

                    int lastLoginId = (int)userCommand.LastInsertedId;


                    // Insert data into the Address table
                    string insertAddressQuery = "INSERT INTO address (HouseName, ApartmentNo, AddressLine1, AddressLine2, Town, County, Postcode) " +
                        "VALUES (@HouseName, @ApartmentNo, @AddressLine1, @AddressLine2, @Town, @County, @Postcode);";
                    MySqlCommand addressCommand = new MySqlCommand(insertAddressQuery, conn);
                    addressCommand.Parameters.AddWithValue("@HouseName", houseAddress);
                    addressCommand.Parameters.AddWithValue("@ApartmentNo", ""); 
                    addressCommand.Parameters.AddWithValue("@AddressLine1", addressLine2);
                    addressCommand.Parameters.AddWithValue("@AddressLine2", "");
                    addressCommand.Parameters.AddWithValue("@Town", town);
                    addressCommand.Parameters.AddWithValue("@County", county);
                    addressCommand.Parameters.AddWithValue("@Postcode", postcode);
                    addressCommand.ExecuteNonQuery();

                    int lastAddressId = (int)userCommand.LastInsertedId;


                    return true;
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("Database error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private string HashPassword(string password)//, string salt)
        {
            /*
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] passwordBytes = Encoding.UTF8.GetBytes(password + salt);
                byte[] hashBytes = sha256.ComputeHash(passwordBytes);
                string hashedPassword = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                return hashedPassword;
*/
            byte[] salt = Encoding.UTF8.GetBytes("23"); //salt value
            using (var hmac = new System.Security.Cryptography.HMACSHA256(salt))
            {
                byte[] hashBytes = hmac.ComputeHash(Encoding.UTF8.GetBytes(password));
                string hashedPassword = BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
                return  hashedPassword;
            }

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}

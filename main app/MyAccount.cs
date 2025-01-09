using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace NEA___D1
{
    public partial class MyAccount : BaseForm
    {
        public MyAccount()
        {
            InitializeComponent();
        }

        private string Email;

        private string PhoneNumber;

        private void MyAccount_Load(object sender, EventArgs e)
        {
            SetDefaultMenuStripStyle();
            GetAccountData();
        }

        private int GetCurrentUserId()
        {
            return Login.CurrentUserId;
        }

        private void GetAccountData()
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT Username, Email, PhoneNumber FROM login, users, address WHERE login.LoginID = address.LoginID AND address.AddressID = users.AddressID AND users.UserID = @userId";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userId", GetCurrentUserId());
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read()) // Assuming UserID is unique, so we expect only one row
                            {
                                // Assuming you have textboxes named txtUsername, txtEmail, and txtPhoneNumber on your form
                                usernameTxtBox.Text = reader["Username"].ToString();
                                EmailTxtBox.Text = reader["Email"].ToString(); 
                                phoneNumTxtBox.Text = reader["PhoneNumber"].ToString();
                                Email = EmailTxtBox.Text;
                                PhoneNumber = phoneNumTxtBox.Text;
                            }
                        }
                    }
                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void UpdateAccountDetails()
        {
            if (Email != EmailTxtBox.Text || PhoneNumber != phoneNumTxtBox.Text)
            {
                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    try
                    {
                        conn.Open();
                        string query = "UPDATE users SET Email = @Email, PhoneNumber = @PhoneNumber WHERE users.UserID = @userId";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@Email", EmailTxtBox.Text);
                            cmd.Parameters.AddWithValue("@PhoneNumber", phoneNumTxtBox.Text);
                            cmd.Parameters.AddWithValue("@userId", GetCurrentUserId());
                            cmd.ExecuteNonQuery();
                        }
                        MessageBox.Show("You have successfully updated your data");
                        Dashboard dboard = new Dashboard();
                        this.Hide();
                        dboard.Show();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
            }
            else
            {
                MessageBox.Show("You have not made any changes");
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            UpdateAccountDetails();
        }
    }
}

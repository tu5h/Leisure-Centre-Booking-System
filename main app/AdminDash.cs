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
    public partial class AdminDash : BaseForm
    {

        public AdminDash()
        {
            InitializeComponent();
        }



        private void AdminDash_Load(object sender, EventArgs e)
        {
            ShowUsers();
            ShowPayments();
            SetPlaceholder(updateTxtBox, "UPDATE");
            SetPlaceholder(searchBox, "SEARCH");
        }

        public static string message;
        //public string[] message = new string[] {"", "", "", "", ""};


        private void sendButton_Click(object sender, EventArgs e)
        {
            message = alertBox.Text;

            /*
            int i = 1++;
            message[i] = alertBox.Text;
            for (int i = 0; i = message.Length ; i++)
            {

            }
            */
        }

        // this routine displays user data from the users, login and address tables
        private void ShowUsers()
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT users.UserID, login.Username, users.FirstName, users.LastName, users.Email, users.PhoneNumber, address.HouseName, address.AddressLine1, address.Town, address.Postcode, address.AddressLine2, address.ApartmentNo FROM login, address, users WHERE login.LoginID = address.LoginID AND address.AddressID = users.AddressID";


                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int colCount = reader.FieldCount;
                                object[] row = new object[colCount];
                                for (int i = 0; i < colCount; i++)
                                {
                                    row[i] = reader.GetValue(i).ToString();
                                }
                                dataGridView.Rows.Add(row);

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

        // this routine displays the contents of the payments table
        private void ShowPayments()
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();

                    string query = "SELECT PaymentID, UserID, BookingID, PaymentDate, Amount FROM payments";


                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                int colCount = reader.FieldCount;
                                object[] row = new object[colCount];
                                for (int i = 0; i < colCount; i++)
                                {
                                    row[i] = reader.GetValue(i).ToString();
                                }
                                dataGridView1.Rows.Add(row);
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

        // this routine opens sign up form
        private void createNewButton_Click(object sender, EventArgs e)
        {
            Signup signUp = new Signup(); 
            signUp.Show();
        }

        // this routine clears the data and shows the default users
        private void refreshNewButton_Click(object sender, EventArgs e)
        {
            dataGridView.Rows.Clear();
            ShowUsers();
        }

        
        private void updateButton_click(object sender, EventArgs e)
        {
            UpdateSelectedCellValue();
        }

        // this routine updates the value of a single cell in the datagridview
        private void UpdateSelectedCellValue()
        {
            if (dataGridView.SelectedCells.Count > 0 && !string.IsNullOrWhiteSpace(updateTxtBox.Text))
            {
                var selectedCell = dataGridView.SelectedCells[0];
                var columnName = dataGridView.Columns[selectedCell.ColumnIndex].Name;
                var selectedRow = dataGridView.Rows[selectedCell.RowIndex];
                var userId = Convert.ToInt32(selectedRow.Cells["UserID"].Value); 
                var newValue = updateTxtBox.Text; 

                // determine which database table column to be updated
                string tableToUpdate = DetermineTable(columnName);
                string query = BuildUpdateQuery(tableToUpdate, columnName, newValue, userId);

                ExecuteUpdateQuery(query, newValue, userId);

                updateTxtBox.Clear();
                dataGridView.Rows.Clear();
                ShowUsers();
            }
            else
            {
                MessageBox.Show("Please select a record and/or provide a new value in the input box.");
            }
        }

        // this function works out what table is being used
        private string DetermineTable(string columnName)
        {
            switch (columnName)
            {
                case "FirstName":
                case "LastName":
                case "Email":
                case "PhoneNumber":
                    return "users";
                case "HouseName":
                case "AddressLine1":
                case "AddressLine2":
                case "Town":
                case "Postcode":
                    return "address";
                default:
                case "Username":
                    return "login";
            }
        }

        // this function builds the update query based on the name of
        // the table passed through and the selected column to update
        private string BuildUpdateQuery(string table, string columnName, string newValue, int userId)
        {
            string query = "";
            if (table.Equals("login"))
            {
                query = "UPDATE login SET " + columnName + " = @newValue WHERE LoginID = (SELECT LoginID FROM users WHERE UserID = @userId)";
            }
            else if (table.Equals("address"))
            {
                query = "UPDATE address SET " + columnName + " = @newValue WHERE AddressID = (SELECT AddressID FROM users WHERE UserID = @userId)";
            }
            else // assumes its the users table
            {
                query = "UPDATE users SET " + columnName + " = @newValue WHERE UserID = @userId";
            }
            return query;
        }

        // sql execute routine for update
        private void ExecuteUpdateQuery(string query, string newValue, int userId)
        {
            using (var conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@newValue", newValue);
                        cmd.Parameters.AddWithValue("@userId", userId);
                        int affectedRows = cmd.ExecuteNonQuery();

                        if (affectedRows > 0)
                        {
                            MessageBox.Show("Update successful.");
                        }
                        else
                        {
                            MessageBox.Show("Update failed or no data was modified.");
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error while updating: {ex.Message}");
                }
            }
        }

        // this routine searches through the database based on the firstname of the user
        private void SearchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchBox.Text;
            if (searchBox.Text == "" | searchBox.Text == "Search")
            {
                searchTerm = "";
                dataGridView.Rows.Clear();
                ShowUsers();
            }
            else
            {

                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    dataGridView.Rows.Clear();
                    try
                    {
                        conn.Open();

                        string query = "SELECT users.UserID, login.Username, users.FirstName, users.LastName, users.Email, users.PhoneNumber, address.HouseName, address.AddressLine1, address.Town, address.Postcode, address.AddressLine2, address.ApartmentNo FROM login, address, users WHERE login.LoginID = address.LoginID AND address.AddressID = users.AddressID AND FirstName LIKE @searchTerm"; // OR LastName LIKE @searchTerm OR UserID LIKE @searchTerm

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("@searchTerm", "%" + searchTerm + "%");

                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                while (reader.Read())
                                {
                                    int colCount = reader.FieldCount;
                                    object[] row = new object[colCount];
                                    for (int i = 0; i < colCount; i++)
                                    {
                                        row[i] = reader.GetValue(i).ToString();
                                    }
                                    dataGridView.Rows.Add(row);
                                }
                            }
                            conn.Close();
                        }
                    }
                    catch (MySqlException ex)
                    {
                        MessageBox.Show("An error occurred while searching: " + ex.Message);
                    }
                }
            }
        }
    }
}

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
    public partial class ManageBookings : BaseForm
    {
        public ManageBookings()
        {
            InitializeComponent();
        }

        private int GetCurrentUserId()
        {
            return Login.CurrentUserId;
        }

        private void ManageBookings_Load(object sender, EventArgs e)
        {
            SetDefaultMenuStripStyle();
            PopulateBookingsData();
        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void PopulateBookingsData()
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT ActivityName, Date, StartTime, EndTime, Price, centre.Name FROM bookings, activity, centre WHERE bookings.ActivityID = activity.ActivityID AND bookings.CentreID = centre.CentreID AND userID = @userID";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@userID", GetCurrentUserId());
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            // Clear the DataGridView before loading new data
                            //dataGridView.Rows.Clear();
                            //dataGridView.AutoGenerateColumns = true;

                            // Iterate through the DataReader and populate the DataGridView

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
    }
}

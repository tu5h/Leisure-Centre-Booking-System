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
    public partial class quickGym : InsertBookings
    {
        public quickGym()
        {
            InitializeComponent();
        }

        private void quickGym_Load(object sender, EventArgs e)
        {
            SetDefaultMenuStripStyle();
            PopulateActivityList();
            selectSiteCombo.SelectedIndexChanged += new EventHandler(selectSiteCombo_SelectedIndexChanged);
        }

        int GetSelectedCentre()
        {
            if (selectSiteCombo.SelectedItem is KeyValuePair<int, string> selectedItem)
            {
                return selectedItem.Key;
            }
            return -1; // Consider handling this case appropriately
        }

        private int GetCurrentUserId()
        {
            return Login.CurrentUserId; // Ensure this method correctly fetches the current user's ID
        }

        private void PopulateActivityList()
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT CentreID, Name FROM bookingsystem.centre";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                selectSiteCombo.Items.Add(new KeyValuePair<int, string>(
                                    reader.GetInt32("CentreID"),
                                    reader.GetString("Name")));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading leisure centres: " + ex.Message);
                }
            }
        }

        private void InsertNewBooking(DateTime slotTime)
        {
            // ActivityID = 6 for the gym
            int activityId = 6;

            DateTime endTime = slotTime.AddHours(1);

            int userId = GetCurrentUserId();

            int centreId = GetSelectedCentre();

            InsertBookingWithLastID(activityId, slotTime, slotTime.ToString("HH:mm:ss"), endTime.ToString("HH:mm:ss"), userId, centreId);

            MessageBox.Show("Booking successful!", "Success: Please proceed with paying at the front desk", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private bool IsSlotAvailable(DateTime slotTime)
        {
            int capacity = 10; 
            int bookingsCount = 0;

            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM bookings WHERE ActivityID = 6 AND Date = @Date AND HOUR(StartTime) = @Hour";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@Date", slotTime.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@Hour", slotTime.Hour);

                    bookingsCount = Convert.ToInt32(cmd.ExecuteScalar());
                }
            }

            return bookingsCount < capacity;
        }

        private DateTime DetermineBookingSlot()
        {
            DateTime now = DateTime.Now;
            DateTime bookingSlot;

            if (now.Hour < 9)
            {
                bookingSlot = new DateTime(now.Year, now.Month, now.Day, 9, 0, 0);
            }
            else if (now.Hour >= 21)
            {
                bookingSlot = new DateTime(now.Year, now.Month, now.Day, 9, 0, 0).AddDays(1);
            }
            else
            {
                bookingSlot = new DateTime(now.Year, now.Month, now.Day, now.Hour, 0, 0);
            }

            return bookingSlot;
        }

        private void selectSiteCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            DateTime slotTime = DetermineBookingSlot();
            if (IsSlotAvailable(slotTime))
            {
                var result = MessageBox.Show("Next available gym slot is at " + slotTime.ToString("HH:mm") + " on " + slotTime.ToString("yyyy-MM-dd") + ". Do you want to book this slot?", "Confirm Booking", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (result == DialogResult.Yes)
                {
                    InsertNewBooking(slotTime);
                }
                else
                {
                    MessageBox.Show("Redirecting to manual booking.");
                    // Redirect to manual booking form
                }
            }
            else
            {
                MessageBox.Show("The selected slot is fully booked. Please choose another time.", "Slot Full", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}

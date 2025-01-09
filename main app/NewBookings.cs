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
    public partial class NewBookings : InsertBookings
    {
        public class BookingActivity
        {
            public string ActivityName { get; set; }
            public string Type { get; set; }
            public int Availability { get; set; }
            public TimeSpan StartTime { get; set; }
        }
        

        public NewBookings()
        {
            InitializeComponent();
            SetDefaultMenuStripStyle();
            InitializeListView();
        }

        private void NewBookings_Load(object sender, EventArgs e)
        {
            InitializeActivityTypesAndCentres();
            SetDefaultSelections();
            DisplayDefaultTimeslots();
            typeOfBookingChecklist.SetSelected(0, true);
        }

        private void InitializeListView()
        {
            // setting the properties of ListView 
            listOfAvailBookings.View = View.Details;
            listOfAvailBookings.FullRowSelect = true;
            listOfAvailBookings.GridLines = true;

            listOfAvailBookings.Columns.Add("Activity", 150, HorizontalAlignment.Left);
            listOfAvailBookings.Columns.Add("Time", 150, HorizontalAlignment.Left);
            listOfAvailBookings.Columns.Add("Availability", 100, HorizontalAlignment.Left);
        }

        private void InitializeActivityTypesAndCentres()
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT distinct type FROM bookingsystem.activity";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                typeOfBookingChecklist.Items.Add(reader.GetString(0));
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading activity types: " + ex.Message);
                }

                // Initialize Leisure Centres
                try
                {
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
        string GetSelectedType()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in typeOfBookingChecklist.CheckedItems)
            {
                sb.Append("'").Append(item.ToString()).Append("', ");
            }
            if (sb.Length > 0)
            {
                sb.Length -= 2;
            }
            return sb.ToString();
        }

        int GetSelectedCentre()
        {
            var selectedItem = (KeyValuePair<int, string>)selectSiteCombo.SelectedItem;
            return selectedItem.Key;
        }

        DateTime GetSelectedDate()
        {
            return dateTimePicker.Value;
        }

        private void SetDefaultSelections()
        {
            // default selection for the selectSiteCombo
            if (selectSiteCombo.Items.Count > 0)
            {
                selectSiteCombo.SelectedIndex = 0;
            }

            // check all items in CheckList
            for (int i = 0; i < typeOfBookingChecklist.Items.Count; i++)
            {
                typeOfBookingChecklist.SetItemChecked(i, true);
            }
        }

        private int GetCurrentUserId()
        {
            return Login.CurrentUserId;
        }

        private List<BookingActivity> FetchActivitiesFromDatabase(string selectedType, int selectedCentre, DateTime selectedDate)
        {
            var activities = new List<BookingActivity>();
            var tempActivities = new List<BookingActivity>();

            // Phase 1: Data Fetching
            using (var conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                var query = "SELECT ActivityName, Type, Availability FROM activity WHERE Type IN (@selectedType)";
                using (var cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@selectedType", selectedType);

                    using (var reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            tempActivities.Add(new BookingActivity
                            {
                                ActivityName = reader.GetString("ActivityName"),
                                Type = reader.GetString("Type"),
                                Availability = reader.GetInt32("Availability"),
                                StartTime = new TimeSpan() // placeholder value
                            });
                        }
                    }
                }
            }

            // Phase 2: Data Processing
            foreach (var activity in tempActivities)
            {
                var timeSlots = Enumerable.Range(9, 1).Select(hour => new TimeSpan(hour, 0, 0)).ToList();
                foreach (var slot in timeSlots)
                {
                    using (var conn = new MySqlConnection(ConnectionString))
                    {
                        conn.Open();
                        var queryCheckBooking = "SELECT COUNT(*) FROM bookings WHERE ActivityID IN (SELECT ActivityID FROM activity WHERE ActivityName = @ActivityName) AND StartTime = @StartTime AND Date = @SelectedDate";
                        //var queryCheckBooking = " SELECT COUNT(*) FROM activity, bookings WHERE activity.ActivityID = bookings.ActivityID AND StartTime = @StartTime AND Date = @SelectedDate AND centreID = @selectedCentre AND activity.ActivityID = (SELECT ActivityID FROM activity WHERE ActivityName = @ActivityName)";

                        using (var cmdCheckBooking = new MySqlCommand(queryCheckBooking, conn))
                        {
                            cmdCheckBooking.Parameters.AddWithValue("@ActivityName", activity.ActivityName);
                            cmdCheckBooking.Parameters.AddWithValue("@StartTime", slot.ToString(@"hh\:mm\:ss"));
                            cmdCheckBooking.Parameters.AddWithValue("@SelectedDate", selectedDate.ToString("yyyy-MM-dd"));
                            cmdCheckBooking.Parameters.AddWithValue("@selectedCentre", selectedCentre);

                            var existingBookings = Convert.ToInt32(cmdCheckBooking.ExecuteScalar());
                            var availability = activity.Availability - existingBookings;

                            // add to the final list if availability is positive, indicating open slots
                            if (availability > 0)
                            {
                                activities.Add(new BookingActivity
                                {
                                    ActivityName = activity.ActivityName,
                                    Type = activity.Type,
                                    Availability = availability,
                                    StartTime = slot
                                });
                            }
                        }
                    }
                }
            }

            return activities;
        }



        private int FetchActivityIdByName(string activityName)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT ActivityID FROM Activity WHERE ActivityName = @ActivityName";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ActivityName", activityName);
                    return Convert.ToInt32(cmd.ExecuteScalar());
                }
            }
        }

        private int CountExistingBookings(int activityId, DateTime selectedDate, string singleTime)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                string query = "SELECT COUNT(*) FROM bookings INNER JOIN activity ON activity.ActivityID = bookings.ActivityID WHERE activity.ActivityID = @ActivityID AND bookings.Date = @Date AND bookings.StartTime = @StartTime";

                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@ActivityID", activityId);
                    cmd.Parameters.AddWithValue("@Date", selectedDate.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@StartTime", singleTime);

                    int totalBookings = Convert.ToInt32(cmd.ExecuteScalar());

                    return totalBookings;
                }
            }
        }


        private void DisplayDefaultTimeslots()
        {
            listOfAvailBookings.Items.Clear();

            string selectedType = GetSelectedType();
            int selectedCentre = GetSelectedCentre();
            DateTime selectedDate = GetSelectedDate();

            var activities = FetchActivitiesFromDatabase(selectedType, selectedCentre, selectedDate);

            foreach (var activity in activities)
            {
                PopulateActivityTimeslots(activity);
            }

            listOfAvailBookings.Refresh();
        }


        private void PopulateActivityTimeslots(BookingActivity activity)
        {
            int startHour = 9; // Starting at 9 AM
            int endHour = 21; // Ending at 9 PM
            int interval = activity.Type == "Sport" ? 1 : 2; // 1-hour interval for sports, 2-hour interval for other types

            // to adjust endHour to ensure we don't create a timeslot beyond the closing time
            endHour -= interval;

            for (int hour = startHour; hour <= endHour; hour += interval)
            {
                string timeRange = $"{new TimeSpan(hour, 0, 0):hh\\:mm} - {new TimeSpan(hour + interval, 0, 0):hh\\:mm}";
                string singleTime = $"{new TimeSpan(hour, 0, 0):hh\\:mm}";
                int activityId = FetchActivityIdByName(activity.ActivityName);
                int availability = activity.Availability - CountExistingBookings(activityId, dateTimePicker.Value.Date, singleTime);
                string[] row = { activity.ActivityName, timeRange, availability.ToString() };
                listOfAvailBookings.Items.Add(new ListViewItem(row));
            }
        }

        private void searchTypeButton_Click(object sender, EventArgs e)
        {
            string selectedType = null;
            if (typeOfBookingChecklist.SelectedItem != null)
            {
                selectedType = typeOfBookingChecklist.SelectedItem.ToString();
            }

            listOfAvailBookings.Items.Clear();

            int selectedCentre = GetSelectedCentre();
            DateTime selectedDate = GetSelectedDate();

            var activities = FetchActivitiesFromDatabase(selectedType, selectedCentre, selectedDate);

            foreach (var activity in activities)
            {
                PopulateActivityTimeslots(activity);
            }

            listOfAvailBookings.Refresh();
        }

        private void makeBookingButton_Click(object sender, EventArgs e)
        {
            if (listOfAvailBookings.SelectedItems.Count > 0)
            {
                string selectedActivity = listOfAvailBookings.SelectedItems[0].SubItems[0].Text;
                string[] times = listOfAvailBookings.SelectedItems[0].SubItems[1].Text.Split('-');
                string startTime = times[0].Trim();
                string endTime = times[1].Trim();
                DateTime selectedDate = dateTimePicker.Value;

                int activityId = FetchActivityIdByName(selectedActivity);
                int userId = GetCurrentUserId();
                int centreId = GetSelectedCentre();

                // Convert startTime and endTime to DateTime
                DateTime startDateTime = DateTime.ParseExact(startTime, "HH:mm", null);
                DateTime endDateTime = DateTime.ParseExact(endTime, "HH:mm", null);

                // Call the modified InsertBooking method and get the booking ID
                int newBookingId = InsertBookingWithLastID(activityId, selectedDate, startDateTime.ToString("HH:mm:ss"), endDateTime.ToString("HH:mm:ss"), userId, centreId);
                MessageBox.Show("Booking made successfully!");

                Payments payment = new Payments();
                payment.ActivityName = selectedActivity;
                payment.bookingID = newBookingId;

                payment.Show();
            }
            else
            {
                MessageBox.Show("Please select a time slot.");
            }
        }

    }
}

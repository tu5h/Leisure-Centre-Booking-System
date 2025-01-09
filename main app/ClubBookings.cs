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
    public partial class ClubBookings : InsertBookings
    {
        public ClubBookings()
        {
            InitializeComponent();
        }

        //routine to load the Club Booking Form and populating the controls
        private void ClubBookings_Load(object sender, EventArgs e)
        {
            SetDefaultMenuStripStyle();

            PopulateActivityList();

            PopulateTimeCombo();
            // The frequency for Advance booking in weeks. A max of 4 weeks.
            SetPlaceholder(frequencyTxtBox, "NUMBER OF WEEKS");

        }

        //routine to validate the data entered in frequency text Box. This is done so that the correct enteries and payment calculatons can be made
        private void frequencyTxtBox_Leave(object sender, EventArgs e)
        {
            if (frequencyTxtBox.Text == "")
            {
                MessageBox.Show("Please enter the number of weeks you would like to book for");
                frequencyTxtBox.Focus();
            }
            else
            {
                int weeks = Convert.ToInt32(frequencyTxtBox.Text);

                if (weeks < 1)
                {
                    MessageBox.Show("You have entered an invalid number of weeks. Please enter 1 - 4");
                    frequencyTxtBox.Focus();
                }
                else if (weeks > 4)
                {
                    MessageBox.Show("You can only book up to 4 weeks in advance");
                    frequencyTxtBox.Focus();
                }
            }
        }

        //routine to handle Date change event
        private void monthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            activityStartDateBox.Text = monthCalendar.SelectionRange.Start.ToShortDateString();
        }

        //funtion to return the selected Leisure centre id from the Combo box
        int GetSelectedCentre()
        {
            var selectedItem = (KeyValuePair<int, string>)selectSiteCombo.SelectedItem;
            return selectedItem.Key;

        }

        //funtion to return the selected activity id from the Combo box
        int GetSelectedActivity()
        {
            var selectedItem = (KeyValuePair<int, string>)activityCombo.SelectedItem;
            return selectedItem.Key;

        }

        //funtion to return the user id 
        private int GetCurrentUserId()
        {
            return Login.CurrentUserId;
        }

        //routine to populate Activity list with all data from the Activity table 
        private void PopulateActivityList()
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    {
                        //open Database connection
                        conn.Open();
                        //form simple sql query
                        string query = "SELECT ActivityID, ActivityName FROM bookingsystem.activity";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            //Execute query into Reader struct
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                //Loop through returned data and populate the two items sought from database
                                while (reader.Read())
                                {
                                    activityCombo.Items.Add(new KeyValuePair<int, string>(
                                        reader.GetInt32("ActivityID"),
                                        reader.GetString("ActivityName")));
                                }
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    //display error message in a message box
                    MessageBox.Show("Error loading activities: " + ex.Message);
                }

                //initialize Leisure Centres by retrieving data from the centre table in the database
                try
                {
                    string query = "SELECT CentreID, Name FROM bookingsystem.centre";
                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        //execute query and returns data into the reader 
                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            //loop through the readers read call to the centre Id and the centre name are populated
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

        //populate the time Combo control with a series of time values from 9am to 10pm
        private void PopulateTimeCombo()
        {
            for (int i = 9; i < 22; i++)
            {
                //Add the second portion of the time value to the time combo contrl
                timeCombo.Items.Add(i + ":00");
            }
        }

        //routine called when the Make Bookling button is clcked
        //this validates and prepares the data for club bookings that 
        //utilizes Recursion algorithm to carry out multiple bookings 
        //until the endpoint is reached, The Endpoint is the frequency specified by a user
        private void makeBookingButton_Click(object sender, EventArgs e)
        {
            if (frequencyTxtBox.Text == "NUMBER OF WEEKS")
            {
                MessageBox.Show("Invalid selection, please complete any missing boxes");
            }
            else
            {
                // Assume frequencyTxtBox has a valid integer between 1 and 4 after frequencyTxtBox_Leave validation
                int frequency = Convert.ToInt32(frequencyTxtBox.Text);
                DateTime startDate;
                DateTime selectedStartTime;
                if (DateTime.TryParse(timeCombo.Text, out selectedStartTime))
                {
                    if (DateTime.TryParse(activityStartDateBox.Text, out startDate))
                    {
                        RecursiveBooking(startDate, frequency, selectedStartTime);
                    }
                    else
                    {
                        MessageBox.Show("Invalid date format.");
                        activityStartDateBox.Focus();
                    }
                }
            }

        }
        private void timeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (timeCombo.SelectedItem != null)
            {
                string selectedTimeAsString = timeCombo.SelectedItem.ToString();
                // Assuming the ComboBox items are in "HH:mm" format and the booking date is today
                DateTime selectedStartTime = DateTime.Today.Add(TimeSpan.Parse(selectedTimeAsString));
            }
        }


        //recursion method for club booking (upt to 4 weeks only permitted)
        private void RecursiveBooking(DateTime startDate, int frequency, DateTime selectedStartTime)
        {
            if (frequency <= 0)
            {
                return; //end point for the recursion, this is when the frequency reaches 0
            }
            //make a booking for the start date selected
            // Example of calling your booking function with the selected start time
            MakeClubBooking(startDate, selectedStartTime);


            //prepare the date for the next booking in a weeks time
            DateTime nextBookingDate = startDate.AddDays(7);

            //recursively call this method with the next date and decremented frequency
            RecursiveBooking(nextBookingDate, frequency - 1, selectedStartTime);
        }


        //routine to add a booking for a given date into the bookings table
        public void MakeClubBooking(DateTime startDate, DateTime selectedStartTime)
        {
            int activityId = GetSelectedActivity(); 
            DateTime date = startDate; 
            string startTime = selectedStartTime.ToString("HH:mm:ss");
            string endTime = selectedStartTime.AddHours(1).ToString("HH:mm:ss"); 

            int userId = GetCurrentUserId();
            int centreId = GetSelectedCentre();

            // call the inherited InsertBooking method with the prepared parameters
            InsertBookingWithLastID(activityId, date, startTime, endTime, userId, centreId);
        }
    }

}

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
    public partial class Dashboard : BaseForm
    {
        //create a new list Panel
        List<Panel> listpanel = new List<Panel>();
        
        //initialise Dashboard
        public Dashboard()
        {
            InitializeComponent();
            SetDefaultMenuStripStyle();

            topBarPanel.BackColor = TopBarColor;

        }

        //Load any messages into the dashboard and also invoke the function that calculates how busy the centre is
        private void Dashboard_Load(object sender, EventArgs e)
        {
            notificationsTxtBox.Text = AdminDash.message;
            calculateBusyStatus();
        }


        private void contactUsButton_Click_1(object sender, EventArgs e)
        {
            //index = 1;
            //listpanel.Add(contactUsPanel);
            //listpanel[index].BringToFront();
            MessageBox.Show("Contact us at 08888 888888");
        }

        private void offersButton_Click(object sender, EventArgs e)
        {
            //index = 2;
            //listpanel.Add(ourOffersPanel);
            //listpanel[index].BringToFront();
            MessageBox.Show("No available offers");
        }

        private void PurposeButton_Click(object sender, EventArgs e)
        {
            //index = 3;
            //listpanel.Add(ourPurposePanel);
            //listpanel[index].BringToFront();
            MessageBox.Show("We are dedicated to enhancing the well-being of individuals of all ages and backgrounds, promoting healthy lifestyles through a wide range of activities, programs, and facilities.");
        }

        //routine to invoke the book now form when the button is clicked on 
        private void bookNowButton_Click(object sender, EventArgs e)
        {
            NewBookings bookingNow = new NewBookings();
            this.Hide();
            bookingNow.Show();
        }

        //routine to invoke the club booking form when the button is clicked on 
        private void clubBookingsButton_Click(object sender, EventArgs e)
        {
            ClubBookings clubBook = new ClubBookings();
            this.Hide();
            clubBook.Show();
        }

        //routine to invoke the My Accounts form when the button is clicked on 
        private void myAccountsButton_Click(object sender, EventArgs e)
        {
            MyAccount myaccount = new MyAccount();
            this.Hide();
            myaccount.Show();
        }

        //routine to invoke the My Bookings form when the button is clicked on
        private void myBookingsButton_Click(object sender, EventArgs e)
        {
            ManageBookings manageBookings = new ManageBookings();
            this.Hide();
            manageBookings.Show();
        }


        private void busyTxtBox_TextChanged(object sender, EventArgs e)
        {
            /*
                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    try
                    {
                        conn.Open();
                        //stores date in YYYY-MM-DD format and 'StartTime' and 'EndTime' are in HH:MM:SS format
                        string query = "SELECT COUNT(BookingID) AS ActiveBookings FROM bookings WHERE Date = CURDATE() AND CURTIME() BETWEEN StartTime AND EndTime";

                        using (MySqlCommand cmd = new MySqlCommand(query, conn))
                        {
                            //execute the query and get the active bookings count
                            int activeBookingsCount = Convert.ToInt32(cmd.ExecuteScalar());

                            //Display the count 
                            MessageBox.Show($"Active bookings count: {activeBookingsCount}");
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message);
                    }
                }
         
            */
        }

        //routine to determine how busy each centre is. This is done 
        //calculaion is done to represent a star for every ten people in
        //for each of the centres 
        private void calculateBusyStatus()
        {
            //iterate through each centre ID and its corresponding text box
            var centreTextBoxMappings = new Dictionary<int, TextBox>
            {
                { 1, busyTxtBox1 },
                { 2, busyTxtBox2 },
                { 3, busyTxtBox3 }
            };

            foreach (var mapping in centreTextBoxMappings)
            {
                int centreId = mapping.Key;
                TextBox textBoxToUpdate = mapping.Value;
                //retrieve all active bookings for each centre
                int bookingCount = GetActiveBookingsForCentre(centreId);
                //Calculate the star value for each of the text controls
                int stars = CalculateStars(bookingCount);

                //invoke on the UI thread to execute the delegate for the underlying control
                this.Invoke((MethodInvoker)delegate
                {
                    textBoxToUpdate.Text = new string('*', stars);
                });
            }
        }

        //retrieve from the database all active bookings per centre
        private int GetActiveBookingsForCentre(int centreId)
        {
            int activeBookings = 0;
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                try
                {
                    conn.Open();
                    string query = "SELECT COUNT(BookingID) AS ActiveBookings FROM bookings WHERE CentreID = @centreID AND Date = CURDATE() AND CURTIME() BETWEEN StartTime AND EndTime";

                    using (MySqlCommand cmd = new MySqlCommand(query, conn))
                    {
                        // Add the centreID as a parameter
                        cmd.Parameters.AddWithValue("@centreID", centreId);

                        // Execute the query and get the active bookings count
                        activeBookings = Convert.ToInt32(cmd.ExecuteScalar());
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return activeBookings;
        }

        //function that calculates how busy a centre is and returns a bookingcount
        private int CalculateStars(int bookingCount)
        {
            if (bookingCount >= 45) return 10;
            return (bookingCount + 4) / 5; //this ensures booking counts maps correctly to the stars scale
        }

        //routine to display the quick gym screen
        private void quickGymButton_Click(object sender, EventArgs e)
        {
            quickGym quickgym = new quickGym();
            this.Hide();
            quickgym.Show();
        }
    }
}

using System;
using System.IO;
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
    public partial class Payments : BaseForm
    {
       
        public Payments()
        {
            InitializeComponent();
        }
        public string ActivityName { get; set; }

        public int bookingID { get; set; }


        // on start, the listener is ran and the payment page is opened
        private async void Payments_Load(object sender, EventArgs e)
        {
            //WebPageOpener.OpenLocalHtmlFile();
            WebPageOpener.StopListener();

            WebPageOpener.OpenPaymentPage(ActivityName);

            WebPageOpener.StartListener();

            // waits a bit before checking again to avoid a tight loop
            while (WebPageOpener.PaymentReturnStatus == null)
            {
                await Task.Delay(100); 
            }

            if (WebPageOpener.PaymentReturnStatus == true)
            {
                // payment successful
                GenerateAndSaveReceipt();
            }
            else
            {
                // if payment failed
                DeleteFailedBooking(bookingID);
            }

        }

        // this routine stops the http listner 
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            WebPageOpener.StopListener();
        }

        // this routine deletes the booking if it fails
        private void DeleteFailedBooking(int bookingId)
        {
            using (MySqlConnection conn = new MySqlConnection(ConnectionString))
            {
                conn.Open();
                // start a transaction
                using (MySqlTransaction trans = conn.BeginTransaction())
                {
                    string deleteQuery = "DELETE FROM bookings WHERE BookingID = @bookingID;";
                    using (MySqlCommand cmd = new MySqlCommand(deleteQuery, conn))
                    {
                        cmd.Transaction = trans; 

                        cmd.Parameters.AddWithValue("@bookingID", bookingId);
                        cmd.ExecuteNonQuery(); 
                    }

                    trans.Commit();
                }
            }
        }


        // this routine saves the reciept to the downloads folder of the user
        // saves using the id, time and activity name
        private void GenerateAndSaveReceipt()
        {
            // gets the path to the users Downloads folder
            var downloadsPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile) + "\\Downloads";

            var receiptFilePath = Path.Combine(downloadsPath, $"Receipt_{bookingID}.txt");

            var receiptContent = new StringBuilder();
            receiptContent.AppendLine("Receipt for Booking");
            receiptContent.AppendLine("Activity Name: " + ActivityName);
            receiptContent.AppendLine($"Booking ID: {bookingID}");
            receiptContent.AppendLine($"Date: {DateTime.Now}");
            receiptContent.AppendLine("Status: Success");

            // writing the receipt to a file using StreamWriter
            try
            {
                using (var writer = new StreamWriter(receiptFilePath))
                {
                    writer.Write(receiptContent.ToString());
                }
                MessageBox.Show($"Receipt saved successfully at: {receiptFilePath}", "Receipt Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Failed to save receipt: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            SavePaymentToDatabase();
        }

        // routine to get current userID.
        private int GetCurrentUserId()
        {
            return Login.CurrentUserId; 
        }

        // this routine will connect to the database and store the booking
        // by linking the two tables activity and booking
        private void SavePaymentToDatabase()
        {
            try
            {
                string price = "";
                using (MySqlConnection conn = new MySqlConnection(ConnectionString))
                {
                    conn.Open();
                    using (MySqlTransaction trans = conn.BeginTransaction())
                    {
                        string selectQuery = "SELECT Price FROM activity, bookings WHERE activity.ActivityID = bookings.ActivityID AND ActivityName = @ActivityName AND bookings.BookingID = @BookingID";
                        using (MySqlCommand cmd = new MySqlCommand(selectQuery, conn))
                        {
                            cmd.Transaction = trans;

                            cmd.Parameters.AddWithValue("@ActivityName", ActivityName);
                            cmd.Parameters.AddWithValue("@BookingID", bookingID);

                            cmd.ExecuteNonQuery();
                            using (MySqlDataReader reader = cmd.ExecuteReader())
                            {
                                if (reader.Read())
                                {
                                    price = reader["Price"].ToString();
                                }
                            }
                        }
                        string insertQuery = "INSERT INTO payments (UserID, BookingID, PaymentDate, Amount) VALUES (@userId, @BookingID, @PaymentDate, @Amount);";
                        using (MySqlCommand cmd = new MySqlCommand(insertQuery, conn))
                        {
                            cmd.Transaction = trans;
                            cmd.Parameters.AddWithValue("@userID", GetCurrentUserId());
                            cmd.Parameters.AddWithValue("@BookingID", bookingID);

                            cmd.Parameters.AddWithValue("@PaymentDate", DateTime.Now);

                            cmd.Parameters.AddWithValue("@Amount", price);

                            cmd.ExecuteNonQuery();
                        }

                        trans.Commit();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error saving to payments: " + ex.Message);
            }

            Dashboard dboard = new Dashboard();
            this.Hide();
            dboard.Show();
        }
    }
}
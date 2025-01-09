using System;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using System.Data.SqlClient;

namespace NEA___D1
{
    public abstract class InsertBookings : BaseForm
    {
        protected MySqlConnection conn;

        public InsertBookings()
        {
            conn = new MySqlConnection(ConnectionString);
        }

        // Virtual method to insert a booking

        protected virtual int InsertBookingWithLastID(int activityId, DateTime date, string startTime, string endTime, int userId, int centreId)
        {
            int bookingId = 0;
            try
            {
                conn.Open();
                using (var trans = conn.BeginTransaction())
                {
                    var cmd = conn.CreateCommand();
                    cmd.Transaction = trans;
                    cmd.CommandText = "INSERT INTO bookings (ActivityID, Date, StartTime, EndTime, UserID, CentreID) VALUES (@ActivityID, @Date, @StartTime, @EndTime, @UserID, @CentreID);";
                    cmd.Parameters.AddWithValue("@ActivityID", activityId);
                    cmd.Parameters.AddWithValue("@Date", date.ToString("yyyy-MM-dd"));
                    cmd.Parameters.AddWithValue("@StartTime", startTime);
                    cmd.Parameters.AddWithValue("@EndTime", endTime);
                    cmd.Parameters.AddWithValue("@UserID", userId);
                    cmd.Parameters.AddWithValue("@CentreID", centreId);
                    cmd.ExecuteNonQuery();

                    // Retrieve the last inserted ID
                    cmd.CommandText = "SELECT LAST_INSERT_ID();";
                    bookingId = Convert.ToInt32(cmd.ExecuteScalar());

                    trans.Commit();
                }
            }
            finally
            {
                if (conn.State == System.Data.ConnectionState.Open)
                {
                    conn.Close();
                }
            }
            return bookingId;
        }
    }
}
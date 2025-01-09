using System;
using System.Windows.Forms;
using System.Drawing;
using MySql.Data.MySqlClient;

using NEA___D1;
public class BaseForm : Form
{
    Font customFont = new Font("Bahnschrift Condensed", 18);
    //Top bar color (50, 50, 85)
    protected Color TopBarColor { get; } = Color.FromArgb(50, 50, 85);

    // Basic background color (41, 44, 54)
    protected Color BackgroundColor { get; } = Color.FromArgb(41, 44, 54);

    //define Panels for Base Form
    protected Panel topBarPanel;
    protected Panel LeftSideBarPanel;
    protected Panel topLeftIconPanel;
    protected MenuStrip menuStrip;

    protected string ConnectionString { get; }

    public BaseForm()
    {
        //Initialise the SQL Server connection string
        ConnectionString = "Server=localhost;Database=BookingSystem;Uid=admin;Pwd=neaschool@3@1;SslMode=none;AllowPublicKeyRetrieval=true;";
        // common settings for all forms
        this.BackColor = BackgroundColor;
        FormBorderStyle = FormBorderStyle.None;
        this.ForeColor = Color.Ivory;
        this.StartPosition = FormStartPosition.CenterScreen;
        // add other common settings or controls here


        // Navigation menu settings
        LeftSideBarPanel = new Panel();
        LeftSideBarPanel.BackColor = Color.Gray; 
        LeftSideBarPanel.Size = new Size(126, 608);
        LeftSideBarPanel.Dock = DockStyle.Left;
        this.Controls.Add(LeftSideBarPanel);

        topLeftIconPanel = new Panel();
        topLeftIconPanel.BackColor = Color.White;
        LeftSideBarPanel.Size = new Size(200, 87);
        LeftSideBarPanel.Dock = DockStyle.Left;
        this.Controls.Add(topLeftIconPanel);

        //create a new instance of the MenuStrip
        menuStrip = new MenuStrip();
        menuStrip.LayoutStyle = ToolStripLayoutStyle.VerticalStackWithOverflow;

        //create a new instance of the DashboardMenuItem
        var dashboardMenuItem = new ToolStripMenuItem("Dashboard");
        dashboardMenuItem.Click += DashboardMenuItem_Click;
        menuStrip.Items.Add(dashboardMenuItem);

        //create a new instance of the booknowMenuItem
        var booknowMenuItem = new ToolStripMenuItem("Book Now");
        booknowMenuItem.Click += BookNowMenuItem_Click;
        menuStrip.Items.Add(booknowMenuItem);

        //create a new instance of the quickGym
        var quickGym = new ToolStripMenuItem("Quick Gym");
        quickGym.Click += quickGym_Click;
        menuStrip.Items.Add(quickGym);

        //create a new instance of the ClubMenuItem
        var ClubMenuItem = new ToolStripMenuItem("Club Bookings");
        ClubMenuItem.Click += ClubMenuItem_Click;
        menuStrip.Items.Add(ClubMenuItem);

        //create a new instance of the myBookings
        var myBookings = new ToolStripMenuItem("My Bookings");
        myBookings.Click += myBooking_Click;
        menuStrip.Items.Add(myBookings);

        //Add All MenuStrip Controls to the Left Side Bar Panel
        LeftSideBarPanel.Controls.Add(menuStrip);

    }

    //routine to set the Default MenuStrip Style for each item
    public void SetDefaultMenuStripStyle()
    {
        foreach (ToolStripItem item in menuStrip.Items)
        {
            if (item is ToolStripMenuItem)
            {
                // Adjust the horizontal padding
                item.Padding = new Padding(35, item.Padding.Top, 40, item.Padding.Bottom);

                item.Font = customFont;
            }
        }
    }

    //on DashboardMenuItem Click event to display the DashBoard
    private void DashboardMenuItem_Click(object sender, EventArgs e)
    {
        Dashboard dboard = new Dashboard();
        this.Hide();
        dboard.Show();
    }
    //on BookNowMenuItem Click event to display the Book Now form
    private void BookNowMenuItem_Click(object sender, EventArgs e)
    {
        NewBookings bookNow = new NewBookings();
        this.Hide();
        bookNow.Show();
    }
    //on quickGym Click event to display the quick Gym form
    private void quickGym_Click(object sender, EventArgs e)
    {
        quickGym quickgym = new quickGym();
        this.Hide();
        quickgym.Show();
    }
    //on ClubMenuItem Click event to display the Club Booking form
    private void ClubMenuItem_Click(object sender, EventArgs e)
    {
        ClubBookings clubBook = new ClubBookings();
        this.Hide();
        clubBook.Show();
    }
    //on myBooking Click event to display the myBooking form
    private void myBooking_Click(object sender, EventArgs e)
    {
        ManageBookings Mybookings = new ManageBookings();
        this.Hide();
        Mybookings.Show();
    }

    // Placeholder textbox method - setting Placeholder text value
    protected void SetPlaceholder(TextBox textBox, string placeholderText)
    {
        textBox.Text = placeholderText;
        textBox.ForeColor = Color.Gray;
        textBox.Name = "Bahnschrift Condensed, 18pt";

        textBox.Enter += (sender, e) =>
        {
            if (textBox.Text == placeholderText)
            {
                textBox.Text = "";
                textBox.ForeColor = Color.Black;
            }
        };
        //When focus from the textbox is lost
        textBox.Leave += (sender, e) =>
        {
            if (string.IsNullOrWhiteSpace(textBox.Text))
            {
                textBox.Text = placeholderText;
                textBox.ForeColor = Color.Gray;
            }
        };
    }

    private void InitializeComponent()
    {
            this.SuspendLayout();
            // 
            // BaseForm
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Name = "BaseForm";
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.ResumeLayout(false);

    }

    private void BaseForm_Load(object sender, EventArgs e)
    {

    }
}

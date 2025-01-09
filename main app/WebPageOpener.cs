using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading.Tasks;
using System.Windows.Forms;


public class WebPageOpener : BaseForm
{
    private static HttpListener _listener;
    private const string ListenerPrefix = "http://localhost:8081/";
    //private bool PaymentReturnStatus = true;
    public static bool? PaymentReturnStatus { get; private set; } = null;


    public static void OpenPaymentPage(string selectedSport)
    {
        string url = $"http://localhost:5555/payments/{selectedSport.ToLower()}";
        try
        {
            Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Failed to open the web page: {ex.Message}");
        }
    }
    
    public static void StartListener()
    {
        _listener = new HttpListener();
        _listener.Prefixes.Add(ListenerPrefix);
        _listener.Start();
        Console.WriteLine("Listening for payment outcomes...");

        Task.Run(() =>
        {
            while (_listener.IsListening)
            {
                try
                {
                    var context = _listener.GetContext();
                    HandleRequest(context);
                }
                catch (Exception ex)
                {
                    // Log error or handle exceptions
                    Console.WriteLine($"An error occurred: {ex.Message}");
                }
            }
        });
    }
    

    private static void HandleRequest(HttpListenerContext context)
    {
        var requestUrl = context.Request.Url.AbsolutePath.ToLower();
        var responseString = "Invalid request";
        if (requestUrl.Contains("/payment/successful"))
        {
            PaymentReturnStatus = true;
            responseString = "Payment Success";
            MessageBox.Show("Payment was successful.");
        }
        else if (requestUrl.Contains("/payment/failure"))
        {
            responseString = "Payment Failure";
            MessageBox.Show("Payment failed.");
            PaymentReturnStatus = false;
        }
        var buffer = System.Text.Encoding.UTF8.GetBytes(responseString);
        context.Response.ContentLength64 = buffer.Length;
        context.Response.OutputStream.Write(buffer, 0, buffer.Length);
        context.Response.OutputStream.Close();
    }

    public static void StopListener()
    {
        if (_listener != null)
        {
            _listener.Stop();
            _listener.Close();
        }
    }

    public static bool? returnStatus()
    {
        return PaymentReturnStatus;
    }

    private void InitializeComponent()
    {
            this.SuspendLayout();
            // 
            // LeftSideBarPanel
            // 
            this.LeftSideBarPanel.Size = new System.Drawing.Size(200, 300);
            // 
            // WebPageOpener
            // 
            this.ClientSize = new System.Drawing.Size(300, 300);
            this.Name = "WebPageOpener";
            this.Load += new System.EventHandler(this.WebPageOpener_Load);
            this.ResumeLayout(false);

    }

    private void WebPageOpener_Load(object sender, EventArgs e)
    {

    }
}
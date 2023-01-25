using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Test.UserControls
{

    public partial class ReportBug : UserControl
    {
        private Timer timer1;
        private bool buttonEnabled = true;
        public ReportBug()
        {
            InitializeComponent();
            timer1 = new Timer();
            timer1.Interval = 2000;
            timer1.Tick += new EventHandler(this.timer1_Tick);
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            if (buttonEnabled)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure you want to send this message?", "Confirmation", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {

                    string text = "```Report: " + guna2TextBox1.Text + "```";
                    string webhookUrl = "";
                    SendMessage(webhookUrl, text);
                    buttonEnabled = false;
                    guna2Button1.Text = "Sent";
                    timer1.Start();
                }
            }
        }
        public static async void SendMessage(string webhookUrl, string message)
        {
            using (var httpClient = new HttpClient())
            {
                var content = new StringContent(JsonConvert.SerializeObject(new
                {
                    content = message
                }), System.Text.Encoding.UTF8, "application/json");

                var response = await httpClient.PostAsync(webhookUrl, content);
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            buttonEnabled = true;
            timer1.Stop();
            guna2Button1.Text = "Report";
        }

        private void ReportBug_Load(object sender, EventArgs e)
        {
            guna2Button1.Text = "Report";
        }
    }
}

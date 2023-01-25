
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Deployment.Application;
using System.Diagnostics;
using System.Drawing;
using System.IO.Compression;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace Test
{
    
    public partial class Form1 : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(
            int nLeftRect,
            int nTopRect,
            int nRightRect,
            int nBottomRect,
            int nWidthEllipse,
            int nHeightEllipse
            );
        public Form1()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }
        private int progs = 1;


        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private async void Form1_Load(object sender, EventArgs e)
        {


            //This is not made like normal but, it truly does
            //help the main app to load by giving it time.
            await Task.Delay(30);
            progs = 30;
            
            guna2CircleProgressBar1.Value = progs;
            await Task.Delay(10);
            progs = 80;
            guna2CircleProgressBar1.Value = progs;
            await Task.Delay(30);
            progs = 100;
            guna2CircleProgressBar1.Value = progs;
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}

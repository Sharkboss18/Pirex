using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Button;

namespace Test
{
    public partial class Form3 : Form
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
        public Form3()
        {
            InitializeComponent();
            this.Region = System.Drawing.Region.FromHrgn(CreateRoundRectRgn(0, 0, Width, Height, 30, 30));
        }


        private void guna2Button2_Click(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                Properties.Settings.Default.MessageBoxDisplayed = true;
                Properties.Settings.Default.Save();
            }
            this.Close();
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://discord.gg/HwMwZHQBhf");
            Properties.Settings.Default.MessageBoxDisplayed = true;
            Properties.Settings.Default.Save();
            
            this.Close();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            
        }

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (guna2CheckBox1.Checked)
            {
                Properties.Settings.Default.MessageBoxDisplayed = true;
                Properties.Settings.Default.Save();
            }
        }
    }
}

using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.UserControls
{
    public partial class UC_Builder : UserControl
    {
        public UC_Builder()
        {
            InitializeComponent();
        }
        private static Random random = new Random();

        

        private void guna2Button2_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.dropbox.com/s/wzotnzg157cht60/picnic_lucasbe_1.2.zip?dl=1");
        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.dropbox.com/s/e1z681r26rysz9g/mondello.zip?dl=1");
            System.Diagnostics.Process.Start("https://www.dropbox.com/s/e1z681r26rysz9g/mondello.zip?dl=1");
        }

        private void guna2Button3_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.beamng.com/threads/2001-07-civetta-mondello-paid.85810/");
        }

        private void guna2Button4_Click_1(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.beamng.com/threads/cherrier-picnic-92-03-paid.84800/");
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.dropbox.com/s/br01ilv1ro67sfh/signia.zip?dl=1");
        }

        private void Signiaoriginal_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://beamng.com/threads/73-77-ibishu-signia-bx-paid.88797/");
        }

        private void M8Original_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://iamthelaw105.gumroad.com/l/bttrv?layout=profile");
        }

        private void M8Download_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.dropbox.com/s/jst7p1k6w824wiw/M8F92IamTheLaw.zip?dl=1");
        }
    }
}

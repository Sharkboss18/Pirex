using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Test.UC_Files;

namespace Test.UserControls
{
    public partial class UC_Download : UserControl
    {

        public UC_Download()
        {
            InitializeComponent();
        }
        private void addusercontrol2(UserControl userControl2)
        {
            userControl2.Dock = DockStyle.Fill;
            guna2ContainerControl2.Controls.Clear();
            guna2ContainerControl2.Controls.Add(userControl2);
            userControl2.BringToFront();
        }

        private void UC_Download_Load(object sender, EventArgs e)
        {
            Physicsmod uc2 = new Physicsmod();
            addusercontrol2(uc2);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {
            Physicsmod uc2 = new Physicsmod();
            addusercontrol2(uc2);
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {
            MollyVX uc2 = new MollyVX();
            addusercontrol2(uc2);
        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {
            SoftVoxels uc2 = new SoftVoxels();
            addusercontrol2(uc2);
        }

        private void guna2Panel4_Paint(object sender, PaintEventArgs e)
        {
            ContinuumAlpha uc2 = new ContinuumAlpha();
            addusercontrol2(uc2);
        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {
            Chronos uc2 = new Chronos();
            addusercontrol2(uc2);
        }

        private void guna2ContainerControl2_Click(object sender, EventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {
            
        }
    }
}

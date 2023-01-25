using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Test.UC_Files
{
    public partial class MollyVX : UserControl
    {
        public MollyVX()
        {
            InitializeComponent();
        }

        private void Mondellodownload_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.dropbox.com/s/eddui2mje2n2hqb/MollyVX-10-25-2022%20%281%29.zip?dl=1");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://rutherin.netlify.app/mollyvx.html");
        }
    }
}

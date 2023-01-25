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
    public partial class Chronos : UserControl
    {
        public Chronos()
        {
            InitializeComponent();
        }

        private void Mondellodownload_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.dropbox.com/s/g7pvmmoys7eiynh/Chronos%20SP0.1.zip?dl=1");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.patreon.com/posts/46916322");
        }
    }
}

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
    public partial class ContinuumAlpha : UserControl
    {
        public ContinuumAlpha()
        {
            InitializeComponent();
        }

        private void ContinuumAlpha_Load(object sender, EventArgs e)
        {

        }

        private void Mondellodownload_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.dropbox.com/s/xbf9dxuxxjcfk5s/Continuum%202.1%20Alpha%20Build%2012.zip?dl=1");
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://continuum.graphics/");
        }
    }
}

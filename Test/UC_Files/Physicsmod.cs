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
    public partial class Physicsmod : UserControl
    {
        public Physicsmod()
        {
            InitializeComponent();
        }

        private void Mondellodownload_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.dropbox.com/s/5beg59zlk8omt8m/crack-physics-mod-pro-v113-fabric-1.19.3.jar?dl=1");
            System.Diagnostics.Process.Start("https://www.dropbox.com/s/r57dyx9ic97tg5e/fabric-api-0.72.0%2B1.19.3.jar?dl=1");
        }


        private void guna2Button1_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.dropbox.com/s/cizrn43wp4ctxs4/crack-physics-mod-pro-v113-forge-1.18.2.jar?dl=1");
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.dropbox.com/s/ctrd177n7fqvqf9/crack-physics-mod-pro-v113-fabric-1.19.2.jar?dl=1");
            System.Diagnostics.Process.Start("https://www.dropbox.com/s/rhmeimcuvh9nk5k/fabric-api-0.68.0%2B1.19.2.jar?dl=1");
        }
    }
}

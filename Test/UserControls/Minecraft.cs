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
    public partial class Minecraft : UserControl
    {
        public Minecraft()
        {
            InitializeComponent();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://minecraftphysicsmod.com/");
        }

        private void Mondellodownload_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("https://www.dropbox.com/s/d3z0t7bpjhiu0ez/physics-mod-pro-v101-fabric-1.19.x.jar?dl=1");
            System.Diagnostics.Process.Start("https://www.dropbox.com/s/rhmeimcuvh9nk5k/fabric-api-0.68.0%2B1.19.2.jar?dl=1");
        }
    }
}

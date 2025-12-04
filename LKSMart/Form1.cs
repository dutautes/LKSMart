using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LKSMart
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void viewTog_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar)
            {
                txtPassword.UseSystemPasswordChar = false;
                viewTog.Image = Properties.Resources.eye_off; // icon saat visible
            }
            else
            {
                txtPassword.UseSystemPasswordChar = true;
                viewTog.Image = Properties.Resources.eye; // icon saat hidden
            }
        }
    }
}

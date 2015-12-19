using System;
using System.Drawing;
using System.Globalization;
using System.Windows.Forms;

using MetroFramework.Forms;

namespace DataBaseLogistic
{
    public partial class Login : MetroForm
    {
        public Login()
        {
            InitializeComponent();
        }

        private void RegisterLink_Click(object sender, EventArgs e)
        {
            Register register = new Register();
            register.Show();
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using MetroFramework.Forms;

namespace DataBaseLogistic
{
    public partial class Register : MetroForm
    {
        public Register()
        {
            InitializeComponent();
        }

        private void UserTextBox_Leave(object sender, EventArgs e)
        {
            bool name_is_success = true;
            bool user_is_success = true;
            bool pass_is_success = true;
            bool mail_is_success = true;
            bool addr_is_success = true;
            String user_account = UserTextBox.Text;
            String user_name = NameTextBox.Text;
            String user_password = PasswordTextBox.Text;
            String user_mail = MailTextBox.Text;


            // the user_account should be in 6 to 20
            if (user_account.Count() <= 20 && user_account.Count() >= 6)
                UserErrorLabel.Visible = false;
            else
                UserErrorLabel.Visible = true;

            if (user_name.Length < 2 || user_name.Length > 4)
                name_is_success = false;
            for (int i = 0; i < user_name.Length; i++)
            {
                if ((int)user_name[i] <= 127)
                    name_is_success = false;
            }
        }
    }
}

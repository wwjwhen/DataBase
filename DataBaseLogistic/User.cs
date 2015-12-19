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
    public partial class User : MetroForm
    {
        public User(String user_name)
        {
            InitializeComponent();
            this.WelcomeNameLabel.Text += user_name + "!";
        }
    }
}

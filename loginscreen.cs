using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heartbeat_monitor
{
    public partial class LoginScreen : UserControl
    {
        Heartbeat heartbeat;
        public LoginScreen(Heartbeat heartbeat)
        {
            this.heartbeat = heartbeat;
            InitializeComponent();
        }

        private void SigninB_Click(object sender, EventArgs e)
        {
            String name = nameBox.Text;
            String password = PassBox.Text;

            PassBox.Text = "";
            nameBox.Text = "";

            heartbeat.loginDatabase(name, password);
        }


    }
}

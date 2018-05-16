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
        public LoginScreen()
        {
            InitializeComponent();
           
        }

        public void AddHeartbeat(Heartbeat heartbeat)
        {
            this.heartbeat = heartbeat;
        }

        private void ClearBox()
        {
            PassBox.Text = "";
            nameBox.Text = "";
        }

        private void SigninB_Click(object sender, EventArgs e)
        {
            String name = nameBox.Text;
            String password = PassBox.Text;

            ClearBox();
            heartbeat.LoginDatabase(name, password);
        }

        private void SignupB_Click(object sender, EventArgs e)
        {
            ClearBox();
            heartbeat.SwitchUserControll(1);
        }
    }
}

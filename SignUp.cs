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
    public partial class SignUp : UserControl
    {
        Heartbeat heartbeat;
        public SignUp()
        {
            InitializeComponent();
        }

        private void ClearBox()
        {
            PassBox.Text = "";
            nameBox.Text = "";
            AuthenticationBox.Text = "";
        }

        public void AddHeartbeat(Heartbeat heartbeat)
        {
            this.heartbeat = heartbeat;
        }

        private void SignUpB_Click(object sender, EventArgs e)
        {
            ClearBox();
            heartbeat.SwitchUserControll(0);
        }

        private void backB_Click(object sender, EventArgs e)
        {
            ClearBox();
            heartbeat.SwitchUserControll(0);
        }
    }
}

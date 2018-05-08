using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Heartbeat_monitor
{
    public partial class Heartbeat : Form
    {
        public Heartbeat()
        {
            InitializeComponent();
        }

        public void loginDatabase(String username, String password)
        {
            //connect to database with credentials
            //incorrect give error message
            //else continue to data
        }

        public void SwitchUserControll(int index)
        {
            //still add all the features
            switch (index) { 
                case 0: break;
            }
        }
    }
}

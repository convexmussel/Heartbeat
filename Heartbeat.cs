using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Heartbeat_monitor
{
    public partial class Heartbeat : Form
    {
        SqlConnection sqlConnection;
        public Heartbeat()
        {
            InitializeComponent();
            loginScreen.AddHeartbeat(this);
            signUp.AddHeartbeat(this);
        }

        private void InitialiseConnectionDatabase()
        {
            //connect to database
        }

        public void LoginDatabase(String username, String password)
        {
            //connect to database with credentials
            //incorrect give error message
            //else continue to data
            
        }

        public void SwitchUserControll(int index)
        {
            //still add all the features
            switch (index) { 
                case 0: loginScreen.BringToFront(); break;
                case 1: signUp.BringToFront(); break;
            }
        }

        public void AddUserDatabase(String username, String password)
        {
            //add user to database
        }

     
    }
}

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
using System.Windows.Forms.DataVisualization.Charting;

namespace Heartbeat_monitor
{
    public partial class Heartbeat : Form
    {
        
        public Heartbeat()
        {
           
            InitializeComponent();
            Init();
        }

        public void Init()
        {
            //add reverense from this form to other panels
            loginScreen.AddHeartbeat(this);
            signUp.AddHeartbeat(this);
            userControl11.AddHeartbeat(this);

            userControl11.Visible = false;
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
            Console.WriteLine("username: "+ username);
            Console.WriteLine("Password: "+ password);

            //succesfull
            SwitchUserControll(2);
            
        }

        public void SwitchUserControll(int index)
        {
            //still add all the features
            switch (index) { 
                case 0: loginScreen.BringToFront(); break;
                case 1: signUp.BringToFront(); break;
                case 2: userControl11.Visible = true; userControl11.BringToFront(); break;
            }
        }

        public void AddUserDatabase(String username, String password)
        {
            //add user to database
        }

        private void loginScreen_Load(object sender, EventArgs e)
        {

        }
    }
}

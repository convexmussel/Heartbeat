using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace Heartbeat_monitor
{
    public partial class UserControl1 : UserControl
    {
        Heartbeat heartbeat;
        public UserControl1()
        {
            InitializeComponent();
            Init();
        }

        public void AddHeartbeat(Heartbeat heartbeat)
        {
            this.heartbeat = heartbeat;
        }

        public void Init()
        {
            this.lineChart.Series["Series1"].Points.AddXY(0,20);
            this.lineChart.Series["Series1"].Points.AddXY(50, 1809);
            
        }

        private void backB_Click(object sender, EventArgs e)
        {
            heartbeat.SwitchUserControll(0);
        }

        private void tableB_Click(object sender, EventArgs e)
        {
            //to table view of the data
        }
    }
}

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
    
        public UserControl1()
        {
            InitializeComponent();
            Init();



        }

        public void Init()
        {
            this.lineChart.Series["Series1"].Points.AddXY(0,20);
            this.lineChart.Series["Series1"].Points.AddXY(50, 1809);





        }

    }
}

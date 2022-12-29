using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using xktComm;
using System.Threading;
using Timer = System.Windows.Forms.Timer;

namespace 按钮封装
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            bool isConnect =siemens.Connect("192.168.0.1", xktComm.Common.CPU_Type.S71500, 0, 0);

            timer.Interval = 500;
            timer.Tick += Timer_Tick;
            if (isConnect)
            {
                timer.Start();
            }
            else
            {
                MessageBox.Show("连接失败");
            }
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            
            foreach (var item in this.Controls)
            {
                if (item is UBlower uBlower)
                {
                    uBlower.start = Convert.ToBoolean(siemens.Read(uBlower.out_address, xktComm.Common.VarType.Bit).ToString());
                }
            }
        }

        private xktComm.SiemensS7 siemens = new SiemensS7();

        private Timer timer = new Timer();

        private void uBlower2_StartClick(object sender, EventArgs e)
        {
            if (sender is UBlower uBlower)
            {
                siemens.Write(uBlower.In_start, 1);
                siemens.Write(uBlower.In_start, 0);
            }
        }

        private void uBlower2_StopCilck(object sender, EventArgs e)
        {
            if (sender is UBlower uBlower)
            {
                siemens.Write(uBlower.In_stop, 1);
                siemens.Write(uBlower.In_stop, 0);
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using S7.Net;
using thinger.DataConvertLib;
using System.Threading;


namespace PID
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Plc plc = new Plc(CpuType.S71500, "192.168.0.1", 0,1);

        

        private void btn_Close_Click(object sender, EventArgs e)
        {
            plc.Close();
            
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            try
            {
                plc.Open();
            }
            catch (Exception)
            {

                MessageBox.Show("连接失败");
                return;
            }
            MessageBox.Show("连接成功");
        }
        private void btn_Run_Click(object sender, EventArgs e)
        {
            plc.Write("M10.0", 1);
            plc.Write("M10.1", 0);
        }

        private void btn_Stop_Click(object sender, EventArgs e)
        {
            plc.Write("M10.1", 1);
            plc.Write("M10.0", 0);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] val = plc.ReadBytes(S7.Net.DataType.Output, 0, 100, 20);

            ////MD100 进水阀门开度
            //float MD100 = BitConverter.ToSingle(new byte[] { val[3], val[2], val[1], val[0] }, 0);
            //this.txt_MD100.Text = (MD100.ToString());

            ////MD104 出水阀门开度
            //float MD104 = BitConverter.ToSingle(new byte[] { val[7], val[6], val[5], val[4] }, 0);
            //this.txt_MD104.Text = (MD104.ToString());

            ////MD108 设定液位值
            //int MD108 = BitConverter.ToInt32(new byte[] { val[11], val[10], val[9], val[8] }, 0);
            //this.txt_MD108.Text = (MD108.ToString());

            ////MD112 当前液位
            //int MD112 = BitConverter.ToInt32(new byte[] { val[15], val[14], val[13], val[12] }, 0);
            //this.txt_MD112.Text = (MD112.ToString());

            ////MD112 当前液位
            //int MD116 = BitConverter.ToInt32(new byte[] { val[19], val[18], val[17], val[16] }, 0);
            //this.txt_MD116.Text = (MD116.ToString());
        }
    }
}
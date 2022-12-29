using S7.Net;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using thinger.DataConvertLib;

namespace test
{
    public partial class fa : Form
    {
        public fa()
        {
            InitializeComponent();
        }
        Plc plc = new Plc(CpuType.S71500, "192.168.0.1", 0,0);
        private void btn_Close_Click(object sender, EventArgs e)
        {
            try
            {
                plc.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("断开失败");
                return;
            }
            this.txt_Connect.Text = "已断开";
        }

        private void btn_Connect_Click(object sender, EventArgs e)
        {
            if (this.txt_Connect.Text == "已连接") 
            {
                MessageBox.Show("请勿重复连接");
                
            }else
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
                this.txt_Connect.Text = "已连接";
            }
        }

        //整型读取
        private void btn_MD100_Click(object sender, EventArgs e)
        {
            object val = plc.Read(this.txt_MD100.Text);

            this.txt_MD100_out.Text = val.ToString();
        }

        //浮点型读取
        private void btn_real_Click(object sender, EventArgs e)
        {
            object val = plc.Read(S7.Net.DataType.Memory, 0, 100, VarType.Real, 1);

            this.txt_real_out.Text = val.ToString();
        }

        private void btn_real_in_Click(object sender, EventArgs e)
        {
            byte[] val = plc.ReadBytes(S7.Net.DataType.Memory, 0, 100, 25);

            //MD100 浮点数

            float MD100 = BitConverter.ToSingle(new byte[] { val[3], val[2], val[1], val[0] },0);
            //MessageBox.Show(MD100.ToString());

            //MD114
            int MD114 = BitConverter.ToInt32(new byte[] { val[17], val[16], val[15], val[14] }, 0);
            //MessageBox.Show(MD114.ToString());

            //MW118
            
            short MW118 = BitConverter.ToInt16(new byte[] { val[19], val[18] }, 0);
            //MessageBox.Show(MW118.ToString());

            //MD120

            int MD120 = BitConverter.ToInt32(new byte[] { val[23], val[22], val[21], val[20] }, 0);
            //MessageBox.Show(MD120.ToString());

            //M124.0
            bool M125 = BitLib.GetBitFromByte(val[24], 3);
            MessageBox.Show(M125.ToString());

        }

        private void btn_write_Click(object sender, EventArgs e)
        {
            plc.Write(this.txt_Write_in.Text, Convert.ToBoolean(1));
        }
    }

    
} 

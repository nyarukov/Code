using Modbus;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 手撕Modbus通讯
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ModbusRtu objmodbusRtu = new ModbusRtu();
        private void btn_Connect_Click(object sender, EventArgs e)
        {
            objmodbusRtu.Connect("COM13", 9600, System.IO.Ports.Parity.None, 8, System.IO.Ports.StopBits.One);
        }

        private void btn_DisConn_Click(object sender, EventArgs e)
        {
            objmodbusRtu.DisConnect();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            byte[] res= objmodbusRtu.ReadOutputState(Convert.ToByte(this.txt_Salve.Text), Convert.ToUInt16(this.txt_start.Text), Convert.ToUInt16(this.txt_length.Text));
            if (res!=null)
            {
                bool[] boolRes = GetBitArrayFromByteArray(res);

            }
        }
        /// <summary>
        /// 字节转数组
        /// </summary>
        /// <param name="b"></param>
        /// <param name="reverse"></param>
        /// <returns></returns>
        private bool[] GetBitArrayFromByte(byte b,bool reverse = false)
        {
            bool[] array = new bool[8];
            if (reverse)
            {
                for (int i = 7; i >=0; i--)
                {
                    array[i] = (b & 1) == 1;
                    b = (byte)(b >> 1);
                }
            }
            else
            {
                for (int i = 0; i<=7 ; i++)
                {
                    array[i] = (b & 1) == 1;
                    b = (byte)(b >> 1);
                }
            }
            return array;
        }

        private bool[] GetBitArrayFromByteArray(byte[] b,bool reverse = false)
        {
            List<bool> res = new List<bool>();
            foreach (var item in b)
            {
                res.AddRange(GetBitArrayFromByte(item, reverse));
            }
            return res.ToArray();
        }
    }
}

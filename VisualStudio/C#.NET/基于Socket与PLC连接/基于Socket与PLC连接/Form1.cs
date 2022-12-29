using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;

namespace 基于Socket与PLC连接
{
    public partial class Socket通讯 : Form
    {
        public Socket通讯()
        {
            InitializeComponent();
        }

        //创建Socket
        private Socket tcpClicnt;
        private void btn_connect_Click(object sender, EventArgs e)
        {
            if (btn_connect.Text == "建立连接")
            {
                //实例化
                tcpClicnt = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                EndPoint Ep = new IPEndPoint(IPAddress.Parse(this.txt_IP.Text), int.Parse(this.txt_Port.Text));
                try
                {
                    tcpClicnt.Connect(Ep);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("连接失败:" + ex.Message);
                    return;
                }
                MessageBox.Show("连接成功");
                this.btn_connect.Text = "连接成功";
                this.btn_close.Text = "断开连接";
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            tcpClicnt?.Close();
            MessageBox.Show("已断开");
            this.btn_close.Text = "已断开";
            this.btn_connect.Text = "建立连接";
        }
    }
}

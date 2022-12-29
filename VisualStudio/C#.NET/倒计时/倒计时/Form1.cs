using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 倒计时
{
    public partial class Form1 : Form
    {
        int cout;
        int time;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 60; i++)
            {
                comboBox1.Items.Add(i.ToString() +"秒");
            }
            label3.Text = " ";

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            cout++;

        }

        private void strat_Click(object sender, EventArgs e)
        {
            timer1.Start();
            time = Convert.ToInt16();
        }
    }
}

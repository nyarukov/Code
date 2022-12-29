using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Speech;
namespace 系统时间
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Txt_Time(object sender, EventArgs e)
        {
            string timestr = DateTime.Now.ToString("G");
            this.txt_time.Text = timestr;
        }
        protected override void OnLayout(LayoutEventArgs levent)
        {
            base.OnLayout(levent);

            int w = ClientSize.Width;
            int h = ClientSize.Height;

            int yoff = 0;
            yoff = 4;

            this.txt_time.Location=new Point(0, yoff);
            this.txt_time.Size = new Size(w, 40);
            this.button1.Location = new Point(w-500,h-150) ;
            this.button1.Size = new Size(80,30);

        }
    }
}

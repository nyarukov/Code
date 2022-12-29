using System;
using System.Windows.Forms;

namespace 按钮封装
{
    public partial class UBlower : UserControl
    {
        public UBlower()
        {
            InitializeComponent();
        }
        public string out_address { get; set; }
        public string In_start { get; set; }
        public string In_stop { get; set; }

        private bool output;

        public event EventHandler StartClick;

        public event EventHandler StopCilck;

        public bool start
        {
            get
            {
                return output;
            }
            set
            {
                output = value;
                if (value)
                {
                    this.Image_Blower.TurnAround = HZH_Controls.Controls.TurnAround.Clockwise;
                }
                else
                {
                    this.Image_Blower.TurnAround = HZH_Controls.Controls.TurnAround.None;
                }
            }
        }

        private void btn_start_BtnClick(object sender, EventArgs e)
        {
            StartClick?.Invoke(this, e);
        }

        private void ucBtnExt1_BtnClick(object sender, EventArgs e)
        {
            StopCilck?.Invoke(this, e);
        }
    }
}

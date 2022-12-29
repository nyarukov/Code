using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 模板
{
    public partial class Home : Sunny.UI.UIForm
    {
        public Home()
        {
            InitializeComponent();
           
        }

        private void Home_Load(object sender, EventArgs e)
        {
            //openfom(new Home());
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            openfom(new Home());
        }

        private void btn_visual_Click(object sender, EventArgs e)
        {
            openfom(new Visual());
            //panelBarLoaction(btn_visual);
        }

        private void btn_parameter_Click(object sender, EventArgs e)
        {
            openfom(new Parameter());
            //panelBarLoaction(btn_parameter);
        }

        private void btn_police_Click(object sender, EventArgs e)
        {
            openfom(new Police());
            //panelBarLoaction(btn_police);
        }

        #region panel位置
        /// <summary>
        /// panel位置
        /// </summary>
        /// <param name="btn"></param>
        //public void panelBarLoaction(Button btn)
        //{
        //    this.panelBar.Location = new Point(btn.Location.X, btn.Location.Y + btn.Size.Height);
        //}
        #endregion

        #region 嵌入子界面
        /// <summary>
        /// 嵌入子界面
        /// </summary>
        /// <param name="frm"></param>
        public void openfom(Form frm)
        {
            
            frm.TopLevel = false;

            frm.TopMost = false;

            //移除Pancel内容
            this.Mainpancel.Controls.Clear();

            //加载窗体
            this.Mainpancel.Controls.Add(frm);
           
            frm.Show();
        }
        #endregion

       
    }
}

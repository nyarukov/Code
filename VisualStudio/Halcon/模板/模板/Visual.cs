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
    public partial class Visual : Form
    {
        public Visual()
        {
            InitializeComponent();
        }

      


        private void btn_Camera_Click(object sender, EventArgs e)
        {
            if (!Camera.OpenCamera(hWindowControl))
            {
                this.Close();
            }
            Camera.GrabImage();
            
        }

        private void btn_CameraStop_Click(object sender, EventArgs e)
        {
            if (Camera.OpenCamera(hWindowControl))
            {
                Camera.CloseCmaera();
            }
            

        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HalconDotNet;

namespace 区域提取
{
    public partial class form : Form
    {
        public form()
        {
            InitializeComponent();
        }
        private void File_open_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Multiselect = false;
            fileDialog.Title = "请选择文件";
            fileDialog.Filter = "图片文件(*.jpg,*.png)|*.jpg;*png";
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string filepath = fileDialog.FileName;
                La_FilePath.Text = filepath;
            }
        }
    }
}

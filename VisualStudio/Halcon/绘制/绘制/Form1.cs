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

namespace 绘制
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btn_readImage_Click(object sender, EventArgs e)
        {
            HImage ho_Image = new HImage();

            ho_Image.ReadImage(@"D:\images\images\7.jpg");

            int Width, Height;

            ho_Image.GetImageSize(out Width, out Height);

            hWindow.HalconWindow.SetPart(0, 0, Height, Width);

            hWindow.HalconWindow.DispImage(ho_Image);

            ho_Image.Dispose();
        }

        private void btn_Circle_Click(object sender, EventArgs e)
        {
            hWindow.Focus();
            hWindow.HalconWindow.DrawCircle(out double row, out double column, out double radius);

            HRegion region = new HRegion();

            region.GenCircle(row, column, radius);

            region.DispRegion(hWindow.HalconWindow);
        }

        private void btn_line_Click(object sender, EventArgs e)
        {
            hWindow.HalconWindow.DrawLine(out double row1, out double column1, out double row2, out double column2);
             
            HRegion region = new HRegion();

            region.GenRegionLine(row1, column1, row2, column2);

            region.DispRegion(hWindow.HalconWindow);
        }

        private void btn_rectangle_Click(object sender, EventArgs e)
        {
            hWindow.HalconWindow.DrawRectangle2(out double row, out double column, out double phi, out double length1, out double length2);

            hWindow.HalconWindow.SetColor("red");

            HRegion region = new HRegion();

            region.GenRectangle2(row, column, phi, length1, length2);

            region.DispRegion(hWindow.HalconWindow);
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
            HalconAPI.CancelDraw();
        }

        private void btn_File_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofg = new OpenFileDialog())
            {
                ofg.Filter = "图片 | *.png;*.jpg";
                ofg.Multiselect = false;
                ofg.Title = "图片读取";
                if (ofg.ShowDialog() == DialogResult.OK)
                {
                    
                }
            }
        }

        
    }
}

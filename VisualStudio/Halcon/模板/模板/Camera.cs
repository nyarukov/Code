using HalconDotNet;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 模板
{
    public class Camera
    {
        //本地图像储存
        static HObject ho_Image;

        //相机引用句柄
        static HTuple hv_AcqHandle = null;

        //相机引用句柄
        static HTuple hWindow_AcqHandle = null;

        //图像高度，宽度
        static HTuple Width, Height;

        /// <summary>
        /// 打开相机
        /// 设置参数
        /// </summary>
        public static bool OpenCamera(HWindowControl HW)
        {
            try
            {
                //打开相机
                HOperatorSet.OpenFramegrabber("DirectShow", 1, 1, 0, 0, 0, 0, "default", 8, "rgb",
                -1, "false", "default", "[1] HD Webcam", 0, -1, out hv_AcqHandle);

                //异步采集
                HOperatorSet.GrabImageStart(hv_AcqHandle, -1);

                //绑定
                hWindow_AcqHandle = HW.HalconWindow;

            }
            catch (Exception)
            {

                return false;
            }
            return true;
        }
        public static bool GrabImage()
        {

            HOperatorSet.GrabImageAsync(out ho_Image, hv_AcqHandle, -1);

            HOperatorSet.GetImageSize(ho_Image, out Width, out Height);

            HOperatorSet.SetPart(hWindow_AcqHandle,0,0,Width-1,Height-1);

            HOperatorSet.DispObj(ho_Image, hWindow_AcqHandle);

            ho_Image.Dispose();

            return true;
        }
        public static void CloseCmaera()
        {
            HOperatorSet.CloseFramegrabber(hv_AcqHandle);

            HOperatorSet.CloseFramegrabber(hWindow_AcqHandle);

            hWindow_AcqHandle.Dispose();

            ho_Image.Dispose();
        }
    }
}

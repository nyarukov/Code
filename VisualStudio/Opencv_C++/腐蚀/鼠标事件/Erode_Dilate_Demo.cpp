#include<opencv2/opencv.hpp>
using namespace cv;

//��ʴ
Mat Erode_Demo(Mat& images) {
	Mat element = getStructuringElement(MORPH_RECT, Size(3, 3));
	Mat img;
	erode(images, img, element);
	return img;
}
//����
Mat Dilate_Demo(Mat& images) {
	Mat element = getStructuringElement(MORPH_RECT, Size(3, 3));
	Mat src;
	dilate(images, src, element);
	return src;
}

Mat Erode_Dilate_Demo(Mat& images) {
	Mat element = getStructuringElement(MORPH_RECT, Size(3, 3));
	Mat src,img;
	erode(images, src, element);
	dilate(src, img, element);
	return img;
}

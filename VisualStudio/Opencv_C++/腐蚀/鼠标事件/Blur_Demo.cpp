#include<opencv2/opencv.hpp>
using namespace cv;

Mat Blur_Demo(Mat& images) {
	Mat img;
	blur(images, img, Size(3, 3));
	return img;
}
Mat Gaussian_Demo(Mat& images) {
	Mat img;
	GaussianBlur(images, img,Size(3,3),1,1);
	return img;
}
Mat Median_Demo(Mat& images) {
	Mat img;
	medianBlur(images, img, 3);
	return img;
	
}
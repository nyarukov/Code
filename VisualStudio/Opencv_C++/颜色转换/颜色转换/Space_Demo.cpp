#include<opencv2/opencv.hpp>
using namespace cv;


void Space_Demo(Mat& images) {
	Mat hsv, gary;
	cvtColor(images, hsv, COLOR_BGR2HSV);
	cvtColor(images, gary, COLOR_BGR2GRAY);
	imshow("hsv", hsv);
	imshow("gary", gary);
}

int main() {
	Mat src = imread("D:\\images\\6.jpg");
	Space_Demo(src);
	waitKey(0);
	destroyAllWindows();
}
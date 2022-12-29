#include<opencv2/opencv.hpp>
using namespace cv;

int main() {
	Mat img = Mat::zeros(Size(600, 600), CV_8SC3);
	imshow("img", img);
	waitKey(0);
	destroyAllWindows();
}
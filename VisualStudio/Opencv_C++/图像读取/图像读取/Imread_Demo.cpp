#include<opencv2/opencv.hpp>
using namespace cv;

int main() {
	Mat src = imread("D:/images/5.jpg");
	imshow("src", src);
	waitKey(0);
	destroyAllWindows();
}
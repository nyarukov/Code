#include<opencv2/opencv.hpp>
#include<iostream>
using namespace std;
using namespace cv;

//腐蚀与膨胀
Mat Erode_Demo(Mat& images);
Mat Dilate_Demo(Mat& images);
Mat Erode_Dilate_Demo(Mat& images);
//int main() {
//	Mat src = imread("D:/images/text.jpg");
//	Mat src1 = Erode_Demo(src);
//	Mat src2 = Dilate_Demo(src);
//	Mat src3 = Erode_Dilate_Demo(src);
//	imshow("images", src);
//	imshow("erode", src1);
//	imshow("diltal", src2);
//	imshow("erode_diltal", src3);
//	waitKey(0);
//	destroyAllWindows();
//}

//滤波
Mat Blur_Demo(Mat& images);
Mat Gaussian_Demo(Mat& images);
Mat Median_Demo(Mat& images);
//int main() {
//	Mat src = imread("D:/images/6.jpg");
//	Mat src1 = Blur_Demo(src);
//	Mat src2 = Gaussian_Demo(src);
//	Mat src3 = Median_Demo(src);
//	imshow("images", src);
//	imshow("blur",src1);
//	imshow("Gaussian", src2);
//	imshow("Median", src3);
//	waitKey(0);
//	destroyAllWindows();
//}

//阈值
//int main() {
//	Mat src=imread("D:/images/6.jpg");
//	Mat src1, src2;
//	cvtColor(src, src1, COLOR_BGR2GRAY);
//	threshold(src1, src2, 127, 255, THRESH_TRUNC);
//	imshow("src", src);
//	imshow("src1", src2);
//	waitKey(0);
//	destroyAllWindows();
//}
//
//bool drawbox=false;
//void Mouse_Demo(int event,int x,int y,int flags,void* param) {
//	if (event == EVENT_LBUTTONDBLCLK) {
//		drawbox = true;
//	}
//	else {
//		drawbox = false;
//	}
//}
//
////鼠标
//int main(int argc,char** argv) {
//	Mat src = Mat::zeros(Size(800, 800), CV_8UC3);
//	namedWindow("mouse");
//	setMouseCallback("mouse",Mouse_Demo, 0);
//	if (drawbox == true) {
//		circle(src, Point(100, 100), 60, Scalar(0, 255, 255), 2, LINE_8);
//	}
//	imshow("q", src);
//	waitKey(0);
//	destroyAllWindows();
//}

//长高通道数
/*int main(int argc, char** argv) {
	Mat img = Mat::zeros(Size(400, 200), CV_8UC3);
	img = Scalar(127, 187, 255);
	cout << img << endl;
	cout <<"长" << img.cols <<"高" << img.rows <<"通道" << img.channels() << endl;
	imshow("xd", img);
	waitKey(0);
	destroyAllWindows();
	return 0;
}*/

//像素操作
/*int main(int argc, char** argv) {
	Mat src = imread("D:/images/6.jpg");
	imshow("原图", src);
	Mat gary;
	cvtColor(src, gary, COLOR_BGR2GRAY);
	imshow("灰度", gary);
	int w = gary.cols;
	int h = gary.rows;
	int channels = gary.channels();
	//数组访问
	for (int row = 0; row < h; row++){
		for (int col=0; col < w; col++) {
			if (channels == 1) {
				int pv = gary.at<uchar>(row, col);
				gary.at<uchar>(row, col) = 255 - pv;
			}
			if (channels == 3) {
				Vec3b bgr=gary.at<Vec3b>(row, col);
				gary.at<Vec3b>(row, col)[0] = 255 - bgr[0];
				gary.at<Vec3b>(row, col)[1] = 255 - bgr[1];
				gary.at<Vec3b>(row, col)[2] = 255 - bgr[2];
			}
		}
	}
	imshow("数组", gary);
	//指针访问
	for (int row = 0; row < h; row++) {
		uchar* img1= gary.ptr<uchar>(row);
		for (int col = 0; col < w; col++) {
			if (channels == 1) {
				int pv = *img1;
				*img1++ = 255 - pv;
			}
			if (channels == 3) {
				*img1++ = 255 - *img1;
				*img1++ = 255 - *img1;
				*img1++ = 255 - *img1;
			}
		}
	}
	imshow("指针", gary);
	waitKey(0);
	destroyAllWindows();
	return 0;
}*/

//算术运算
/*int main(int argc, char** argv) {
	Mat img = imread("D:/images/5.jpg");
	Mat dst1 = Mat::zeros(img.size(), img.type());
	Mat dst2 = Mat::zeros(img.size(), img.type());
	dst1 = Scalar(2, 2, 2);
	add(img, dst1, dst2);
	imshow("img", img);
	imshow("add", dst2);
	subtract(img, dst1, dst2);
	imshow("sub", dst2);
	multiply(img, dst1, dst2);
	imshow("mul", dst2);
	divide(img, dst1, dst2);
	imshow("div", dst2);
	waitKey(0);
	destroyAllWindows();
}*/

//亮度调整
//Mat img, dst, dst1;
//int brightness = 50;
//static void on_nav(int, void*) {
//	dst = Scalar(brightness);
//	add(img, dst, dst1);
//	imshow("src", dst1);
//}
//
//int main(int argc,char** argv) {
//	int max = 100;
//	img = imread("D:/images/5.jpg");
//	dst = Mat::zeros(img.size(), img.type());
//	dst1 = Mat::zeros(img.size(), img.type());
//	namedWindow("src", WINDOW_AUTOSIZE);
//	createTrackbar("蓝色", "src", &brightness, max, on_nav);
//	on_nav(50, 0);
//	waitKey(0);
//	destroyAllWindows();
//}

//亮度bgr调整
//static void on_nav_demo(int b, void* userdata) {
//	Mat image = *((Mat*)userdata);
//	Mat dst = Mat::zeros(image.size(), image.type());
//	Mat dst1 = Mat::zeros(image.size(), image.type());
//	dst1 = Scalar(b, b, b);
//	addWeighted(image, 1, dst1, 1, 0, dst);
//	imshow("img", dst);
//
//}
//static void on_nav_demo_b(int b, void* userdata) {
//	Mat image = *((Mat*)userdata);
//	Mat dst = Mat::zeros(image.size(), image.type());
//	Mat dst1 = Mat::zeros(image.size(), image.type());
//	dst1 = Scalar(b,0,0);
//	addWeighted(image, 1, dst1, 1, 0, dst);
//	imshow("img", dst);
//
//}
//static void on_nav_demo_g(int b, void* userdata) {
//	Mat image = *((Mat*)userdata);
//	Mat dst = Mat::zeros(image.size(), image.type());
//	Mat dst1 = Mat::zeros(image.size(), image.type());
//	dst1 = Scalar(0,b,0);
//	addWeighted(image, 1, dst1, 1, 0, dst);
//	imshow("img", dst);
//
//}
//static void on_nav_demo_r(int b, void* userdata) {
//	Mat image = *((Mat*)userdata);
//	Mat dst = Mat::zeros(image.size(), image.type());
//	Mat dst1 = Mat::zeros(image.size(), image.type());
//	dst1 = Scalar(0,0, b);
//	addWeighted(image, 1, dst1, 1, 0, dst);
//	imshow("img", dst);
//
//}
//void on_nav(Mat& image) {
//	cv::namedWindow("img", WINDOW_AUTOSIZE);
//	int b = 0;
//	int g = 0;
//	int r = 0;
//	int brightness = 0;
//	int max_brightness = 100;
//	cv::createTrackbar("亮度调整", "img", &brightness, max_brightness, on_nav_demo, (void*)(&image));
//	cv::createTrackbar("蓝色", "img", &b, max_brightness, on_nav_demo_b, (void*)(&image));
//	cv::createTrackbar("绿色", "img", &g, max_brightness, on_nav_demo_g, (void*)(&image));
//	cv::createTrackbar("红色", "img", &r, max_brightness, on_nav_demo_r, (void*)(&image));
//	on_nav_demo(50, &image);
//	on_nav_demo_b(50, &image);
//	on_nav_demo_g(50, &image);
//	on_nav_demo_r(50, &image);
//}
//
//int main(int argc, char** argv) {
//	Mat src = imread("D:/images/5.jpg");
//	on_nav(src);
//	waitKey(0);
//	destroyAllWindows();
//}

//int main() {
//	Mat src = imread("D:/images/5.jpg");
//	Mat img = imread("D:/images/6.jpg");
//	Mat dst = Mat::zeros(src.size(), src.type());
//	cout << src.cols<<" " << src.rows <<" " << src.channels() << endl;
//	cout << img.cols<<" " << img.rows <<" "<< img.channels() << endl;
//	//addWeighted(src, 1, img, 1, 1, dst);
//	imshow("img", img);
//	imshow("src", src);
//	waitKey(0);
//	destroyAllWindows();
//}

//像素值操作
//int main(int argc, char** argv) {
//	Mat dst = Mat::zeros(Size(400, 400), CV_8UC3);
//	Mat dst1 = Mat::zeros(Size(400, 400), CV_8UC3);
//	dst = Scalar(150,255, 67);
//	rectangle(dst, Rect(100, 100, 170, 170), Scalar(0, 175, 255), -1, LINE_8, 0);
//	rectangle(dst1, Rect(150, 150, 150, 100), Scalar(255, 175, 0), -1, LINE_8, 0);
//	imshow("dst", dst);
//	imshow("dst1", dst1);
//	Mat dst2;
//	bitwise_or(dst, dst1, dst2);
//	imshow("dst2", dst2);
//	waitKey(0);
//	destroyAllWindows();
//}

//分离与混合
//int main(int argc, char** argv) {
//	Mat img = imread("D:/images/5.jpg");
//	Mat dst;
//	vector<Mat> m;
//	split(img, m); //通道分离
//	m[1] = 0;
//	m[2] = 0;
//	merge(m, dst); //混合
//	imshow("img", dst);
//	waitKey(0);
//	destroyAllWindows();
//}

//背景操作
//int main(int argc, char** argv) {
//	Mat img = imread("D:/images/27.jpg");
//	Mat hsv, dst;
//	cvtColor(img, hsv, COLOR_BGR2HSV);
//	inRange(hsv, Scalar(35,43,46), Scalar(77,255,255), dst);//二值化
//	imshow("inrange", dst); 
//	Mat dst1 = Mat::zeros(img.size(), img.type());
//	dst1 = Scalar(40, 40, 200);//背景
//	bitwise_not(dst, dst);//取反提取ROI
//	img.copyTo(dst1,dst);//融合
//	imshow("ROI", dst1);
//	waitKey(0);
//	destroyAllWindows();
//}


#include<opencv2/opencv.hpp>
#include<string>
using namespace cv;

void Img_Demo(Mat& images) {
	String text = "hello world!";
	line(images, Point(200, 200), Point(400, 400), Scalar(0, 0, 255), 2,LINE_8);
	rectangle(images, Point(200, 200), Point(400, 400), Scalar(0.255, 175), 2, LINE_8);
	circle(images, Point(300, 300), 100, Scalar(0, 255, 0), 2, LINE_4);
	ellipse(images,Point(400,350),Size(100,100),40,180,360,Scalar(255,124,0),2);
	putText(images, text, Point(100, 100), FONT_HERSHEY_COMPLEX, 2, (255,255,255), 2);
	imshow("images", images);
}

int main() {
	Mat img = Mat::zeros(Size(800, 800), CV_8UC3);
	while (true)
	{
		Img_Demo(img);
		if (waitKey(25) == 27) {
			break;
		}
	}
	destroyAllWindows();
}
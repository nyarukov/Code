from turtle import shape
import cv2
import numpy
img = cv2.imread("D:/images/1.png")
src=img[300:800,300:800]
cv2.imshow("sdf",src)
cv2.waitKey(0)
cv2.destroyAllWindows()
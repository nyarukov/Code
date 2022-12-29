import cv2
from cv2 import WINDOW_NORMAL
import numpy as np

img=cv2.imread('D:/images/10.jpg')
# cv2.imshow('img',img)
#均值滤波
src=cv2.blur(img,(3,3))
# cv2.imshow('blur',src)
#高斯滤波
src1=cv2.GaussianBlur(img,(3,3),1)
# cv2.imshow('Gaussian',src1)
#中值滤波
src2=cv2.medianBlur(img,5)
# cv2.imshow('median',src2)
res=np.vstack((img,src,src1,src2))
gary=cv2.cvtColor(res,cv2.COLOR_BGR2GRAY)
hsv=cv2.cvtColor(res,cv2.COLOR_BGR2HSV)
cv2.namedWindow('gary',WINDOW_NORMAL)
cv2.namedWindow('hsv',WINDOW_NORMAL)
cv2.imshow('gary',gary)
cv2.imshow('hsv',hsv)
cv2.waitKey(0)
cv2.destroyAllWindows()
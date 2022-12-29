import cv2
from cv2 import Sobel
import numpy as np

def Sobel_Demo():
    img_circle=cv2.circle(img,(300,300),175,(255,255,255),-1)
    img_Sobelx=cv2.Sobel(src,cv2.CV_64F,1,0,ksize=1)
    img_Sobely=cv2.Sobel(src,cv2.CV_64F,0,1,ksize=1)
    img_Sobelx=cv2.convertScaleAbs(img_Sobelx)
    img_Sobely=cv2.convertScaleAbs(img_Sobely)
    total=cv2.addWeighted(img_Sobelx,0.5,img_Sobely,0.5,0)
    cv2.imshow('total',total)
    cv2.imshow('src',src)

img=np.zeros([600,600,3],np.uint8)
src=cv2.imread('D:/images/6.jpg',cv2.IMREAD_GRAYSCALE)
while(1):
    Sobel_Demo()
    if cv2.waitKey(20) &0XFF == 27:
        break
cv2.destroyAllWindows()
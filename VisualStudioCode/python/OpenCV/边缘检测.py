from doctest import OutputChecker
import cv2
import numpy as np

def EdgeDetection_Demo():
    Gaussian=cv2.GaussianBlur(frame,(3,3),1)
    Sobelx=cv2.Sobel(Gaussian,cv2.CV_64F,1,0,ksize=3)
    Sobely=cv2.Sobel(Gaussian,cv2.CV_64F,0,1,ksize=3)
    Sobelx=cv2.convertScaleAbs(Sobelx)
    Sobely=cv2.convertScaleAbs(Sobely)
    Sobelxy=cv2.addWeighted(Sobelx,0.3,Sobely,0.3,0)
    Sobelxy1=cv2.Canny(Sobelxy,50,100)
    Sobelxy2=cv2.Canny(Sobelxy,150,250)
    Sobelxyz=np.hstack((Sobelxy1,Sobelxy2))
    cv2.namedWindow('img_out',cv2.WINDOW_NORMAL)
    cv2.namedWindow('frame',cv2.WINDOW_NORMAL)
    cv2.imshow('img_out',Sobelxyz)
    cv2.imshow('frame',frame)

cap=cv2.VideoCapture('D:/images/86.mkv')
img =cv2.imread('D:/images/RC1.jpg',cv2.IMREAD_GRAYSCALE)
while(1):
    ret,frame=cap.read()
    EdgeDetection_Demo() 
    if cv2.waitKey(25) & 0XFF ==27:
        break
cap.release()
cv2.destroyAllWindows()
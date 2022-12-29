import cv2
import numpy as np

def TOPHAT_Demo():
    TOPHAT=cv2.morphologyEx(img,cv2.MORPH_TOPHAT,kerenl)
    OPEN=cv2.morphologyEx(img,cv2.MORPH_OPEN,kerenl)
    total1=np.hstack((img,OPEN,TOPHAT))
    cv2.namedWindow('total1',cv2.WINDOW_NORMAL)
    cv2.imshow('total1',total1)

def BLACKHAT_Demo():
    BLACKHAT=cv2.morphologyEx(img,cv2.MORPH_BLACKHAT,kerenl)
    CLOSE=cv2.morphologyEx(img,cv2.MORPH_CLOSE,kerenl)
    total2=np.hstack((img,CLOSE,BLACKHAT))
    cv2.namedWindow('total2',cv2.WINDOW_NORMAL)
    cv2.imshow('total2',total2)

kerenl=np.ones((7,7),np.uint8)
img=cv2.imread('D:/images/text.jpg')
while(1):
    TOPHAT_Demo()
    BLACKHAT_Demo()
    if cv2.waitKey(20) & 0XFF == 27:
        break
cv2.destroyAllWindows()

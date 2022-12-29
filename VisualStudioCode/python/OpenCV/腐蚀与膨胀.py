import cv2
import numpy as np

def threshold_demo():
    #腐蚀
    # ret,src=cv2.threshold(gary,127,255,cv2.THRESH_BINARY_INV)
    src1=cv2.erode(img,(3,3),iterations=1)
    res=np.hstack((img,src1))
    cv2.namedWindow('src',cv2.WINDOW_NORMAL)
    cv2.imshow('src',res)
# def dilate_demo():
#     #膨胀
#     ret,gary1=cv2.threshold(gary,127,255,cv2.THRESH_BINARY_INV)
#     gary2=cv2.dilate(gary1,(3,3),iterations=1)
#     rea=np.hstack((gary,gary1,gary2))
#     cv2.namedWindow('images',cv2.WINDOW_NORMAL)
#     cv2.imshow('images',rea)

img=cv2.imread('D:/images/text.jpg')

while(1):
    # gary=cv2.cvtColor(img,cv2.COLOR_BGR2GRAY)
    threshold_demo()
    if cv2.waitKey(20) & 0XFF==27:
        break
cv2.destroyAllWindows()
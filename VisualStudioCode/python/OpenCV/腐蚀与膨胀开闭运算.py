import cv2
import numpy as np

# 单个
def threshold_dilate_demo():
    src=cv2.erode(img,(3,3),iterations=6)
    src1=cv2.dilate(src,(3,3),iterations=7)
    src2=np.hstack((img,src,src1))
    cv2.namedWindow('demo',cv2.WINDOW_NORMAL)  
    cv2.imshow('demo',src2)

#开运算，先腐蚀，后膨胀
def morphologyEx_demo1():
    src10=cv2.morphologyEx(img,cv2.MORPH_OPEN,(3,3))
    src11=np.hstack((img,src10))
    cv2.namedWindow('demo1',cv2.WINDOW_NORMAL)
    cv2.imshow('demo1',src11)

#闭运算，先膨胀，后腐蚀
def morphologyEx_demo2():
    src20=cv2.morphologyEx(img,cv2.MORPH_CLOSE,(3,3))
    src21=np.hstack((img,src20))
    cv2.namedWindow('demo2',cv2.WINDOW_NORMAL)
    cv2.imshow('demo2',src21)
    
img=cv2.imread('D:/images/text.jpg')
while(1):
    # threshold_dilate_demo()
    morphologyEx_demo1()
    morphologyEx_demo2()
    if cv2.waitKey(20) & 0XFF==27:
        break
cv2.destroyAllWindows()
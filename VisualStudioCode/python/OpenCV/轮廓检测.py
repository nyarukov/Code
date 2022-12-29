import cv2
from cv2 import THRESH_BINARY
from cv2 import THRESH_BINARY_INV


def Outline_Demo():
    gary=cv2.cvtColor(img,cv2.COLOR_BGR2GRAY)
    ret,gary1=cv2.threshold(gary,175,255,THRESH_BINARY)
    cv2.imshow("gary1",gary1)
    binary,contours,hierarchy=cv2.findContours(gary1,cv2.RETR_TREE,cv2.CHAIN_APPROX_NONE)
    gary2=gary1.copy()
    res=cv2.drawContours(gary2,contours,-1,(0,0,255),2)
    cv2.imshow("res",res)

img=cv2.imread("D:/images/5.jpg")
while(1):
    cv2.imshow("img",img)
    Outline_Demo()
    if cv2.waitKey(20)& 0XFF==27:
        break
cv2.destroyAllWindows()
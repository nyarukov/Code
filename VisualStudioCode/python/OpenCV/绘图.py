from cmath import isclose
from inspect import isclass
import cv2
import numpy as np

src=cv2.imread("D://images/5.jpg")
src1=cv2.imread("D://images/5.jpg")
src2=cv2.imread("D://images/5.jpg")
src3=cv2.imread("D://images/5.jpg")
src4=cv2.imread("D://images/5.jpg")
src5=cv2.imread("D://images/5.jpg")
cv2.line(src,(200,200),(400,400),(255,0,0),2)
cv2.rectangle(src1,(600,600),(400,800),(255,255,0),2)
cv2.circle(src2,(400,400),200,(0,0,255),2)
cv2.ellipse(src3,(256,256),(100,50),20,0,360,(255,255,0),2)
pst=np.array([[0,10],[100,30],[70,20],[50,10]],np.int32)
cv2.polylines(src4,[pst],True,(255,255,34),2)
text="Hello world!"
cv2.putText(src5,text,(200,400),cv2.FONT_HERSHEY_COMPLEX,2,(255,0,255),2)
cv2.imshow("line",src)
cv2.imshow("rectangle",src1)
cv2.imshow("circle",src2)
cv2.imshow("ellipse",src3)
cv2.imshow("polylines",src4)
cv2.imshow("puttext",src5)
k=cv2.waitKey(0)
if(k==ord('q')):
    cv2.destroyAllWindows()


from cgitb import text
import cv2 as cv
from cv2 import FONT_HERSHEY_COMPLEX
import cv2

def color_space_demo():
    gary=cv.cvtColor(frame,cv.COLOR_BGR2GRAY)
    color_space= cv.CascadeClassifier('D:/Project/OpenCv/opencv/build/etc/haarcascades/haarcascade_frontalface_alt2.xml')
    color=color_space.detectMultiScale(gary)
    for x,y,w,h in color:
        cv.rectangle(frame,(x,y),(x+w,y+h),(0,0,255),3)
        cv.putText(frame,name,(x-10,y-10),FONT_HERSHEY_COMPLEX,1,(0,255,0),2)
        cv2.rectangle(frame,(x-10,y-10),(x+30,y+30),(0,255,0),2)
    cv.imshow("frame",frame)

num=1
name="dfgd"
cap=cv.VideoCapture(0)
while(1):
    ret,frame=cap.read()
    color_space_demo()
    k=cv.waitKey(20)
    if (k==ord('s')):
        cv.imwrite("D://images/"+str(num)+".jpg",frame)
        print("D://images/"+str(num)+".jpg")
        print('--------------------------------------------')
        num+=1
    elif (k==ord('q')):
        break
cv.destroyAllWindows()


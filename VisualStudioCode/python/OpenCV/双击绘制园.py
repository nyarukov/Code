# from asyncio import events
# import cv2
# events=[i for i in dir(cv2) if 'EVENT' in i]
# print(events)

import cv2
from cv2 import FONT_HERSHEY_PLAIN
from cv2 import FONT_HERSHEY_DUPLEX


def draw(event,x,y,flags,param):
    if event==cv2.EVENT_MOUSEMOVE and flags==cv2.EVENT_LBUTTONDOWN:
        cv2.rectangle(src,(x,y),(x+100,y+100),(155,100,0),2)
    if event==cv2.EVENT_LBUTTONDBLCLK:
        cv2.circle(src,(x,y),70,(100,255,0),2)
cv2.namedWindow("rectangle")
cv2.setMouseCallback("rectangle",draw)
src=cv2.imread("D://images/6.jpg")
while(1):
    cv2.imshow("rectangle",src)
    
    k=cv2.waitKey(20)
    if (k==ord('q')):
        break
cv2.destroyAllWindows()
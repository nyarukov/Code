import cv2

cap=cv2.VideoCapture(0)

while(1):
    ret,frame=cap.read()
    hsv=cv2.cvtColor(frame,cv2.COLOR_BGR2HSV)
    gray=cv2.cvtColor(frame,cv2.COLOR_BGR2GRAY)
    cv2.imshow("hsv",hsv)
    cv2.imshow("gray",gray)
    cv2.imshow("rgb",frame)
    cv2.waitKey(25)
cap.relaese()
cv2.destroyAllWindows()
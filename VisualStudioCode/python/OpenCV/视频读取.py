import cv2

cap=cv2.VideoCapture("D://images/video.mp4")

while(1):
    ret,frame=cap.read()
    cv2.namedWindow("video",cv2.WINDOW_NORMAL)
    cv2.resizeWindow("video",1920,1080)
    cv2.imshow("video",frame)
    cv2.waitKey(25)
    
import cv2

img=cv2.imread('D:/images/5.jpg')
img1=img+10
cv2.imshow('img',img)
cv2.waitKey(0)
cv2.destroyAllWindows()
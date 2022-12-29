import cv2

img=cv2.imread('D:/images/5.jpg')
img1=cv2.imread('D:/images/6.jpg')
print('img',img.shape)
print('img1',img1.shape)
img2=cv2.resize(img1,(1000,563))
print('img1',img2)
img3=cv2.addWeighted(img,0.2,img2,0.1,100)
cv2.imshow('img',img)
cv2.imshow('img1',img1)
cv2.imshow('img3',img3)
cv2.waitKey(0)
cv2.destroyAllWindows()
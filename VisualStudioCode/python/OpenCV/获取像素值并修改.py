import cv2

img=cv2.imread("D://images/7.png")
px=img[10,10]
print(px)
blue=img[100,100,0]
print(blue)
img[101,101]=[255,255,255]
print(img[101,101])


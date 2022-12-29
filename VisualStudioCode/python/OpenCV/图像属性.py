import cv2
import numpy
img = cv2.imread("D://images/5.jpg")
print(img.item(10,10,2))
img.itemset((10,10,2),100)
print(img.item(10,10,2))        
print(img.shape)    #行，列，通道数的元组
print(img.size)     #像素数目
print(img.dtype)    #数据类型
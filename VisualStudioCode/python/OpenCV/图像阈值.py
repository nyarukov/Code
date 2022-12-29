import cv2
import matplotlib.pyplot as plt
from matplotlib.pyplot import title

img=cv2.imread('D:/images/5.jpg')
img1=cv2.cvtColor(img,cv2.COLOR_BGR2GRAY)
ret,src1=cv2.threshold(img1,127,255,cv2.THRESH_BINARY)  #超过阈值取最大，其余为0
ret,src2=cv2.threshold(img1,127,255,cv2.THRESH_BINARY_INV)  #超过阈值取0，其余255
ret,src3=cv2.threshold(img1,127,255,cv2.THRESH_TRUNC)   #大于阈值取阈值，其余不变
ret,src4=cv2.threshold(img1,127,255,cv2.THRESH_TOZERO)  #大于阈值不变，其余为0
ret,src5=cv2.threshold(img1,127,255,cv2.THRESH_TOZERO_INV)  #大于阈值取0，其余不变
while(1):
    cv2.imshow('img',img)
    cv2.imshow('src1',src1)
    cv2.imshow('src2',src2)
    cv2.imshow('src3',src3)
    cv2.imshow('src4',src4)
    cv2.imshow('SRC5',src5)
    # cv2.imshow('gary',img1)
    if cv2.waitKey(20) & 0XFF==27:
        break
cv2.destroyAllWindows()

# titles=['BINARY','INV']
# images=[img,src1,src2]

# for i in range(3):
#     plt.subplot(2,3,i+1),plt.imshow(images[i],'gary')
#     plt.title[titles[i]]
#     plt.xticks([]),plt.yticks([])
# plt.show()
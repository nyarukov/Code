import cv2

top_size,bootm_size,left_size,right_size=(50,50,50,50)

img=cv2.imread('D:/images/5.jpg')
src=cv2.copyMakeBorder(img,top_size,bootm_size,left_size,right_size,cv2.BORDER_REPLICATE) #复制法
src1=cv2.copyMakeBorder(img,top_size,bootm_size,left_size,right_size,cv2.BORDER_REFLECT) #反射法
src2=cv2.copyMakeBorder(img,top_size,bootm_size,left_size,right_size,cv2.BORDER_REFLECT_101) #反射法
src3=cv2.copyMakeBorder(img,top_size,bootm_size,left_size,right_size,cv2.BORDER_WRAP) #包装法
src4=cv2.copyMakeBorder(img,top_size,bootm_size,left_size,right_size,cv2.BORDER_CONSTANT) #常量法
while(1):
    cv2.imshow('Original drawing',img)
    cv2.imshow('Reproduction method',src)
    cv2.imshow('Reflection method',src1)
    cv2.imshow('Reflection method 1',src2)
    cv2.imshow('Packaging method',src3)
    cv2.imshow('Constant method',src4)
    if cv2.waitKey(20) & 0xFF==27:
        break
cv2.destroyAllWindows()

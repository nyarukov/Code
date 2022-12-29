
import cv2

img=cv2.imread("D://images/7.png")
cv2.namedWindow("acc",cv2.WINDOW_NORMAL)
cv2.resizeWindow("acc",300,400)
cv2.imshow("acc",img)
k=cv2.waitKey(0)
if  k==ord('d'):
    cv2.imwrite("D://images/ryty.png",img)
    cv2.destroyAllWindows()

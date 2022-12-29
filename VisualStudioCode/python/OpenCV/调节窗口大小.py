import cv2

src = cv2.imread("D://images/7.png")
cv2.namedWindow("input",cv2.WINDOW_NORMAL)
cv2.resizeWindow("input",300,400)
cv2.imshow("input",src)
cv2.waitKey(0)
cv2.destroyAllWindows()
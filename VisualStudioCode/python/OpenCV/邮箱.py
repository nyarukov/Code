from email.mime.text import MIMEText
from email.utils import formataddr
import smtplib
# # SMTP服务器以及相关配置信息
# smtp_sever = 'smtp.163.com'
# from_addr = 'luckychaoyue5@163.com'
# password = 'KTNMMGFCMAGHOPZJ'  # 授权码
# to_addr = 'elpsycongroo5@163.com'
# # 1.创建邮件(写好邮件内容、发送人、收件人和标题等)
# msg = MIMEText('检测到人脸','plain','utf-8')
# msg['From'] = formataddr(('Milk',from_addr)) # 发件人昵称和邮箱
# msg['To'] = formataddr(('tyu',to_addr)) # 收件人昵称和邮箱
# msg['Subject'] = '你好,有一封报告请查看'  # 邮件标题
# # 2.登录账号
# sever = smtplib.SMTP(smtp_sever,25) # 明文传输端口号是25
# sever.login(from_addr,password)
# # 3.发送邮件
# sever.sendmail(from_addr,to_addr,msg.as_string())
# sever.quit()


 # SMTP服务器以及相关配置信息
smtp_sever = 'smtp.163.com'
from_addr = 'milkyouki@163.com'
password = 'UDCWRPNQNCXEREPH'  # 授权码
to_addr = 'elpsycongroo5@163.com'
# 1.创建邮件(写好邮件内容、发送人、收件人和标题等)
msg = MIMEText('检测到人脸','plain','utf-8')
msg['From'] = formataddr(('Milk',from_addr)) # 发件人昵称和邮箱
msg['To'] = formataddr(('tyu',to_addr)) # 收件人昵称和邮箱
msg['Subject'] = '你好,有一封报告请查看'  # 邮件标题
# 2.登录账号
# sever = smtplib.SMTP(smtp_sever,25) # 明文传输端口号是25
# sever.login(from_addr,password)
# # 3.发送邮件
# sever.sendmail(from_addr,to_addr,msg.as_string())
# sever.quit()
try:
    smtpObj = smtplib.SMTP() 
    smtpObj.connect(smtp_sever, 25)    # 25 为 SMTP 端口号
    smtpObj.login(from_addr,password)
    smtpObj.sendmail(from_addr,to_addr,msg.as_string())
    print ("邮件发送成功")
except smtplib.SMTPException:
    print ("邮件发送失败")
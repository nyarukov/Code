import requests
import re

url = 'https://fanyi.sogou.com/reventondc/suggV3'
s=input("请输入要翻译的文本：\n")

headers = {
    "user-agent": "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/108.0.0.0 Safari/537.36"
}
dat = {
    "from": "auto",
    "client":  "web",
    "text":  s,
    "uuid": "f8a7a7dd-9c9c-4c96-9a03-8f3ee48e5600",
    "pid":  "sogou-dict-vr",
    "addSugg":  "on"
}
resp = requests.post(url=url,headers=headers,data=dat)
obj=re.compile(r'"k":"(?P<tran>.*?)","v":"(?P<n>.*?)"}',re.S)
resuil =obj.finditer(resp.text)
for it in resuil:
    print(it.group('tran'), '\t',it.group('n'))
resp.close()
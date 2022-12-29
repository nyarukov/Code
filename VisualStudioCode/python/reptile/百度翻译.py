import requests

url = 'https://fanyi.baidu.com/sug'
s=input("请输入要翻译的文本：\n")

dat={
    "kw": s
}
resp=requests.post(url, data=dat,)

print(resp.json())
resp.close()
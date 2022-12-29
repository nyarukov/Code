import requests
import re


url = 'https://www.bilibili.com/v/popular/all'

dic_h = {
    "user-agent": "Mozilla/5.0 (X11; Linux x86_64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/108.0.0.0 Safari/537.36"
}

resp = requests.get(url=url, headers=dic_h)
# with open("index.html",'w') as f:
#     f.write(resp.text)
obj =re.compile(r'target="_blank" class="title">(?P<name>.*?)</a>.*?'
                                r'<div class="detail"><span class="data-box">(?P<words>.*?)</span>.*?'
                                r'alt="play">(?P<score>.*?)</span>',re.S)
result = obj.finditer(resp.text)
with open("index2.md",'w') as f:
    for i in result:
        f.write(i.group("name"))
        f.write('\t')
        f.write(i.group("words").strip())
        f.write('\t')
        f.write(i.group("score").strip())
        f.write('\n')

resp.close()
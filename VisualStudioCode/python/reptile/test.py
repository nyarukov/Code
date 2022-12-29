# import requests
# import re

# s= """
#     target="_blank" class="title">路人超能100 III(灵能百分百 第三季)</a>
#     target="_blank" class="title">间谍过家家</a>
#     target="_blank" class="title">奇幻世界舅舅</a> 
#     target="_blank" class="title">孤独摇滚！</a>
# """

# obj = re.compile(r'target="_blank" class="title">(?P<name>.*?)</a>',re.S)
# resuit = obj.finditer(s)
# for it in resuit:
#     print(it.group('name'))

import openpyxl

# 打开工作簿
wb = openpyxl.load_workbook("text.xlsx")

# 选择工作表
ws = wb["Sheet1"]

# 获取 A1 单元格
cell = ws["A1"]

# 调整字体字号
cell.font = openpyxl.styles.Font(size=22)

# 保存工作簿
wb.save("text.xlsx")

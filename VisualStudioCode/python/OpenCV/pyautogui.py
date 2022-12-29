# import pyautogui


# # 将鼠标移动到固定位置
# pyautogui.moveTo(100, 100)
# # 用“1秒”的时间移动到固定位置
# pyautogui.moveTo(100, 100, duration=1)
# # 将鼠标移动到相对当前“下方100”的位置
# pyautogui.moveRel(0, 100) 


# # 鼠标左键拖拽到屏幕“100，200”的位置
# pyautogui.dragTo(100, 200, button='left') 
# # 鼠标左键用“2秒”拖拽到屏幕“300，400”的位置
# pyautogui.dragTo(300, 400, 2, button='left') 
# # 鼠标左键用“2秒”拖拽到相对当前“右边30”的位置
# pyautogui.dragRel(30, 0, 2, button='left')
# ### button属性可以有：left\middle\right


# # 鼠标左键单击
# pyautogui.click()
# # 鼠标左键单击“100，200”位置
# pyautogui.click(x=100, y=200)
# # 鼠标左键双击
# pyautogui.doubleClick()
# # 鼠标左键三击
# pyautogui.tripleClick()
# # 鼠标右键单击
# pyautogui.click(button='right')
# # 鼠标右键单击
# pyautogui.rightClick()
# # 鼠标右键间隔0.25秒单击3次
# pyautogui.click(button='right', clicks=3, interval=0.25)


# # 鼠标左键放下
# pyautogui.mouseDown()
# # 鼠标左键抬起
# pyautogui.mouseUp()


# # 鼠标滚轮上滚10
# pyautogui.scroll(300)
# # 鼠标滚轮下滚10
# pyautogui.scroll(-200)

# 输入一个字符串
# pyautogui.typewrite('Hello world!')
# 每个字母间隔0.25秒输入一个字符串
# pyautogui.typewrite('Hello world!', interval=0.25) 
# # 键入 "a", 然后敲击左方向键, 再键入 "b".
# pyautogui.typewrite(['a','left','b'])


# # 按键
# pyautogui.press('esc')
# # 连续按键
# pyautogui.press(['left', 'left', 'left', 'left', 'left', 'left'])


# # 键盘按下
# pyautogui.keyDown('shift')
# # 键盘释放
# pyautogui.keyUp('shift')

# # 热键按住ctrl的同时按下c
# pyautogui.hotkey('ctrl', 'c')
# pyautogui.alert(text='你好吗', title='问候', button='我很好')
# pyautogui.confirm(text='你好吗', title='问候', buttons=['我很好', '我不好', '不告诉你'])
# pyautogui.prompt(text='你好吗', title='问候' , default='')

# x,y = pyautogui.position()
# print ("当前鼠标的X轴的位置为：{}，Y轴的位置为：{}".format(x,y))

# x,y = pyautogui.size()
# print ("当前屏幕的分辨率是{}*{}".format(x,y))

# pyautogui.moveTo(x=300,y=300,duration=0.25)
# # pyautogui.click(x=100,y=150,button='left')
# # pyautogui.doubleClick(x=100,y=150,button="left")
# pyautogui.dragTo(x,y,duration=0.25)
# pyautogui.hotkey('win', 'r')
# pyautogui.typewrite(message="hello world",interval=0.25)

# 暂停2.5s
# pyautogui.PAUSE = 2.5
# # 用num_seconds(秒)将鼠标移动到(x,y)位置
# x = 200
# y = 100
# num_seconds = 1
# pyautogui.moveTo(x, y, duration=num_seconds)  

# # 用num_seconds(秒)将鼠标从当前位置向右移动xOffset，向下移动yOffset
# # 如果duration为0或未指定，则立即移动。
# xOffset = 30
# yOffset = -50
# num_seconds = 0.5
# pyautogui.moveRel(xOffset, yOffset, duration=num_seconds) 
# 0

# # 用num_seconds(秒)将鼠标推动到(x,y)位置
# # 鼠标拖动是指按下鼠标左键移动鼠标。
# x = 200
# y = 100
# num_seconds= 1
# pyautogui.dragTo(x, y, duration=num_seconds)  

# # 用num_seconds(秒)将鼠标从当前位置向右拖动xOffset，向下推动yOffset
# xOffset = 30
# yOffset = -50
# num_seconds = 0.5
# pyautogui.dragRel(xOffset, yOffset, duration=num_seconds) 

# 将鼠标移动到(moveToX,moveToY)位置，点击鼠标num_of_clicks次，每次点击间隔secs_between_clicks秒
# button表示单击方式，'left'左键单击，'middle'中键单击，'right'右键单击
# moveToX = 500
# moveToY = 600
# num_of_clicks = 1
# secs_between_clicks = 1
# pyautogui.click(x=moveToX, y=moveToY, clicks=num_of_clicks, interval=secs_between_clicks, button='left')
# moveToX = 10
# moveToY = 20
# # 右键单击
# pyautogui.rightClick(x=moveToX + 50, y=moveToY)
# # 中键单击
# pyautogui.middleClick(x=moveToX + 50, y=moveToY)
# # 左键双击
# pyautogui.doubleClick(x=moveToX + 50, y=moveToY)
# # 左键三击
# pyautogui.tripleClick(x=moveToX + 50, y=moveToY)
# moveToX = 100
# moveToY = 200
# # 鼠标在当前位置向下滑动100格
# # pyautogui.scroll(clicks=-100)
# # 鼠标移动到(moveToX,moveToY)位置，然后向上滚动150格
# pyautogui.scroll(clicks=150, x=moveToX, y=moveToY)
# 鼠标移动到(moveToX,moveToY)位置，鼠标左键按下
# pyautogui.mouseDown(x=moveToX, y=moveToY, button='left')
# # 鼠标移动到(moveToX,moveToY)位置，鼠标右键松开（按下右键的情况下）
# pyautogui.mouseUp(x=moveToX, y=moveToY, button='right')
# # 鼠标在当前位置，按下中键
# pyautogui.mouseDown(button='middle')


# set keyboard layout
# 设置键盘布局

# from win32con import WM_INPUTLANGCHANGEREQUEST
# import win32gui
# import win32api

# # 语言代码
# # https://msdn.microsoft.com/en-us/library/cc233982.aspx
# LID = {0x0804: "Chinese (Simplified) (People's Republic of China)",
#        0x0409: 'English (United States)'}

# # 获取前景窗口句柄
# hwnd = win32gui.GetForegroundWindow()

# # 获取前景窗口标题
# title = win32gui.GetWindowText(hwnd)
# print('当前窗口：' + title)

# # 获取键盘布局列表
# im_list = win32api.GetKeyboardLayoutList()
# im_list = list(map(hex, im_list))
# print(im_list)

# # 设置键盘布局为英文
# result = win32api.SendMessage(
#     hwnd,
#     WM_INPUTLANGCHANGEREQUEST,
#     0,
#     0x0409)
# if result == 0:
#     print('设置英文键盘成功！')


# import os
# text=os.path.exists('C:/Users/Milk/Documents/6.jpg')
# if text==True:
#     print('文件存在')
# elif text==False:
#     print("文件不存在")

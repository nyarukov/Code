#include<stdio.h>
#include<stdlib.h>//system
#include<windows.h>//Sleep
#include<string.h>//strlen

int main()
{
    char arr1[]="hello!word!";//定义数组一
    char arr2[]="###########";//定义数组二
    int left=0;//从左下标开始
    int right=strlen(arr1)-1; //右下标
    while(left<=right)//只有左下标和右下标中有值循环
    {
        arr2[left]=arr1[left];//左下标替换
        arr2[right]=arr1[right];//右下标替换
        printf("%s\n",arr2);
        Sleep(1000);//停止1秒
        system("cls");//清除屏幕
        left++;
        right--;
    }
    printf("%S\n",arr2);
    return 0;
}
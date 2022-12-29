#include <stdio.h>
int main()
{

    int reg=0;
    int ch=0;
    char password[20]={0};//建立数组
    printf("请输入密码:");
    scanf("%s",password);//存储数组
    while((ch=getchar()) !='\n')//知道读完\n才停止
    {
        ;//执行空语句
    }
    
    printf("请确认:（Y/N)");
    reg=getchar();//读取\n
    if(reg=='Y')
    {
    printf("确认成功\n");
    }
    else
    {
    printf("放弃确认\n");
    }
    return 0;
}
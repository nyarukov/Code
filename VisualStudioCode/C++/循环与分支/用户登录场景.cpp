#include<stdio.h>
#include<string.h>

int main()
{
    char password[20]={};
    int a=0;
    for(a=0;a<3;a++)
    {
        printf("����������:");
        scanf("%s",password);
        if(strcmp(password, "123456")==0)
        {
            printf("������ȷ\n");
            printf("��ӭʹ��\n");
            break;
        }
        else
        {
            printf("�������\n");
        }
    }
    if(a==3)
    {
        printf("��������˳�����\n");
    }
    return 0;
}
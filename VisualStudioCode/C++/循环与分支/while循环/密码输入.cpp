#include <stdio.h>
int main()
{

    int reg=0;
    int ch=0;
    char password[20]={0};//��������
    printf("����������:");
    scanf("%s",password);//�洢����
    while((ch=getchar()) !='\n')//֪������\n��ֹͣ
    {
        ;//ִ�п����
    }
    
    printf("��ȷ��:��Y/N)");
    reg=getchar();//��ȡ\n
    if(reg=='Y')
    {
    printf("ȷ�ϳɹ�\n");
    }
    else
    {
    printf("����ȷ��\n");
    }
    return 0;
}
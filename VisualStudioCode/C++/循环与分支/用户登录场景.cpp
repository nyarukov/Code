#include<stdio.h>
#include<string.h>

int main()
{
    char password[20]={};
    int a=0;
    for(a=0;a<3;a++)
    {
        printf("ÇëÊäÈëÃÜÂë:");
        scanf("%s",password);
        if(strcmp(password, "123456")==0)
        {
            printf("ÃÜÂëÕýÈ·\n");
            printf("»¶Ó­Ê¹ÓÃ\n");
            break;
        }
        else
        {
            printf("ÃÜÂë´íÎó\n");
        }
    }
    if(a==3)
    {
        printf("ÃÜÂë´íÎó£¬ÍË³ö³ÌÐò\n");
    }
    return 0;
}
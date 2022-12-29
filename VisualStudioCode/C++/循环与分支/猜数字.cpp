#include<stdio.h>
void menu()
{
    printf("****************************************************\n");
    printf("*******      1.开始              2.退出       ******\n");
    printf("****************************************************\n");
}
int main()
{
    int input=0;
    do
    {
        menu();
        printf("请选择：\n");
        scanf("%d",&input);
        switch(input)
        {
            case 1:
             printf("游戏\n");
            break;
            case 2:
             printf("退出游戏\n");
            break;
            default:
             printf("退出游戏\n");
             break;
        }
    } while (input);
    return 0;
    
}
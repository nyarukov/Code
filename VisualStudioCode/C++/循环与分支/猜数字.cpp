#include<stdio.h>
void menu()
{
    printf("****************************************************\n");
    printf("*******      1.��ʼ              2.�˳�       ******\n");
    printf("****************************************************\n");
}
int main()
{
    int input=0;
    do
    {
        menu();
        printf("��ѡ��\n");
        scanf("%d",&input);
        switch(input)
        {
            case 1:
             printf("��Ϸ\n");
            break;
            case 2:
             printf("�˳���Ϸ\n");
            break;
            default:
             printf("�˳���Ϸ\n");
             break;
        }
    } while (input);
    return 0;
    
}
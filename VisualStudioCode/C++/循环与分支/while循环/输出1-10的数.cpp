#include<stdio.h>
//contiune会跳过当前值
int main()
{
    int a=1;
    while(a<10)
    {
        a++;
        if(a==5)
        continue;
        printf("%d\n",a);

    }
    return 0;
}

//break会停止输出到设定条件值
// int main()
// {
//     int a=1;
//     while(a<=10)
//         {
//         if(a==5)
//         break;
//         printf("%d\n",a);
//         a++;
//         }
//         return 0;
// }

//普通输出1-10
// int main()
// {
// int a=1;
//     while(a<=10)
// {
//         printf("%d",a);
//     a++;
// } 
//     return 0; 
// }
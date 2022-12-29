#include<stdio.h>

int main()
{
    int year=0;
    int a=0;
    for(year=2000;year<=3000;year++)
    {
        if(((year%4==0)&&(year%100!=0))||(year%400==0))
        {
            printf(" %d",year);
            a++;
        }
    }
    printf("\n����%d",a);
    return 0;

}




// int main()
// {
//     int year=0;
//     int a=0;
//     for(year=2000;year<=3000;year++)
//     {
//         if(year%4==0 && year%100!=0)
//         {
//             printf(" %d",year);
//             a++;
//         }
//         else
//         {
//             if(year%400==0)
//             {
//                 printf(" %d",year);
//                 a++;
//             }
//         }
//     }
//     printf("\n2000��-3000�꣬������%d��",a);

// }
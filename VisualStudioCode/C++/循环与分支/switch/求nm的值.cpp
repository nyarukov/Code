#include<stdio.h>

int main()
{
    int n=1;    
    int m=2;    
    switch(n)
    {
    case 1:
        m++;
    case 2:
        n++;
    case 3: //n=2,m=3
        switch(n)   //n=2,m=3,n为入口n=2,从case2执行
        {
            case 1:
                n++;
            case 2: 
                m++;
                n++;
            break;
        }
    case 4: //n=3,m=4
        m++;
    case 5:
        switch(n)
        {
            case 1:
                n++;
            case 2:
                m++;
            case 3:
                n++;
                m++;
            case 4:
                m++;
            break;
        }
    default:
        break;
    }
    printf("m=%d,n=%d\n",m,n);
    return 0;
}
#include<stdio.h>
int main()
{
    int a=0;
    int b=0;
    int r=0;
    scanf("%d%d",&a,&b);
    while(a%b)
    {
        r=a%b;
        a=b;
        b=r;
    }
    printf("%d",b);
}
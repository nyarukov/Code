#include <stdio.h>

int main()
{
    //EOF -end of file 文件结束标志
    int a=0;
    while((a=getchar()) != EOF)
    {
        putchar(a);
    }
    return 0;
}
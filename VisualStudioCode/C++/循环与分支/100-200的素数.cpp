#include <stdio.h>
int main()
{
    int a = 0;
    int c = 0;
    for (a = 100; a <= 200; a++)
    {
        int b = 0;
        for (b = 2; b < a; b++)
        {
            if (a % b == 0)
            {
                break;
            }
        }
        if (a == b)
        {
            c++;
            printf(" %d", a);
        }
    }
    printf("\n%d", c);
    return 0;
}
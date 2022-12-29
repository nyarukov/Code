#include<stdio.h>
int main()
{
    int a=0;
    int arr[]={-19,-30,1,30,49,58,67,69,78,98};
    int b=arr[0];
    int sz=sizeof(arr)/sizeof(arr[0]);
    for(a=1;a<sz;a++)
    {
        if(arr[a]>b)
        {
            b=arr[a];
        }

    }
    printf("%d",b);
    return 0;
}
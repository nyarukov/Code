#include <iostream>
using namespace std;
int main()
{
    int i,j,t;
    int arr[]={1,5,9,8,7,4,6,3,2,0};        
    int sz=sizeof(arr)/sizeof(arr[0]);      
for(i=0;i<sz;i++)                           
    {
        for(j=0;j<sz-1;j++)                 
        {
            if(arr[j]<arr[j+1])         
            {
                t=arr[j];
                arr[j]=arr[j+1];
                arr[j+1]=t;
            }
        }
    }
    for(i=0;i<sz;i++)
    {
    cout<<arr[i];
    }
       return 0;
}
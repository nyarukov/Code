#include <iostream>
using namespace std;

void swap(int arr[], int i, int j) {
    int tmp = arr[i];
    arr[i] = arr[j];
    arr[j] = tmp;
}

void PrintArray(int arr[], short length) {
    for (int i = 0; i < length; i++)
    {
        int MinValue = i;
        for (int j = i + 1; j < length; j++)
        {
            MinValue = arr[j] < arr[MinValue] ? j : MinValue;
        }
        swap(arr, i, MinValue);
        cout << arr[i] + " ";
    }

}


int main()
{
    int array[] = { 3,5,6,2,6,8,4,8,9,2,4 };
    int length = sizeof(array) / sizeof(array[0]);
    PrintArray(array, length);
}
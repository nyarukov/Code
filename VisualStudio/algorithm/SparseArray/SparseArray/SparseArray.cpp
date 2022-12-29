#include <iostream>
using namespace std;

int main()
{
    int array[11][11] = { 0 };
    int rows = sizeof(array) / sizeof(array[0]);
    int columns = sizeof(array[0]) / sizeof(array[0][0]);
    array[1][2] = 1;
    array[2][3] = 2;
    cout << "数组初始化\n";
    int sum;
    for (int i = 0; i < rows; ++i)
    {
        for (int j = 0; j < columns; ++j)
        {
            if (array[i][j]!=0)
            {
                sum++;
            }
        }
    }
}
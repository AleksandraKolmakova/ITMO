#include <iostream>
using namespace std;


//шаблон функции вычисления среднего значения элементов массива
template<class T>
void average(T arr[], int size)
{
    double sum = 0;
    for (int i = 0; i < size; i++) 
        sum += arr[i];
    cout << sum / size << endl;
}

int main()
{
    //массив
    int arr[] = { 9, 3, 17, 6, 5, 4, 31, 2, 12 };
    double arrd[] = { 2.1, 2.3, 1.7, 6.6, 5.3, 2.44, 3.1, 2.4, 1.2 };
    char arrc[] = { "Wello, world!" };
    long arrl[] = { 4567345, 52376548, 12534685 };
    int k1 = sizeof(arr) / sizeof(arr[0]); 
    int k2 = sizeof(arrd) / sizeof(arrd[0]); 
    int k3 = sizeof(arrc) / sizeof(arrc[0]) - 1; 
    int k4 = sizeof(arrl) / sizeof(arrl[0]);
    //вызов функции
    average(arr, k1);
    average(arrd, k2);
    average(arrc, k3);
    average(arrl, k4);
}
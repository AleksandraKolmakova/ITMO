#include <iostream>
using namespace std;

//функция сортировки, два параметра массив целых чисел и его размер
void sorting(int arr[], int size)
{
    int j = 0;
    for (int i = 0; i < size; i++)
    {
        int x = arr[i];
        for (j = i - 1; j >= 0 && x < arr[j]; j--)
            arr[j + 1] = arr[j];
        arr[j + 1] = x;
    }
}

//шаблон функции на основе функции сортировки
template<class T>
void sorting(T arr[], int size)
{
    int j = 0;
    for (int i = 0; i < size; i++)
    {
        T x = arr[i];
        for (j = i - 1; j >= 0 && x < arr[j]; j--)
            arr[j + 1] = arr[j];
        arr[j + 1] = x;
    }
}

//шаблон функции вывода массивов различных типов на экран
template<class S>
void showArr(S arr[], int size)
{
    for (int i = 0; i < size; i++)
        cout << arr[i] << "; ";
    cout << endl;
}

int main()
{
    //массив
    int arr[] = { 9, 3, 17, 6, 5, 4, 31, 2, 12 };
    double arrd[] = { 2.1, 2.3, 1.7, 6.6, 5.3, 2.44, 3.1, 2.4, 1.2 };
    char arrc[] = { "Wello, world!" };
    int k1 = sizeof(arr) / sizeof(arr[0]); //9
    int k2 = sizeof(arrd) / sizeof(arrd[0]); //9
    int k3 = sizeof(arrc) / sizeof(arrc[0])-1; //13
    //вызов функции сортировки
    sorting(arr, k1);
    //вывод на экран отсортированного массива
   /* for (int i = 0; i < k1; i++)
        cout << arr[i] << "; ";
    cout << endl;*/
    showArr(arr, k1);

    sorting(arrd, k2);
   /* for (int i = 0; i < k2; i++)
        cout << arrd[i] << "; ";
    cout << endl;*/
    showArr(arrd, k2);

    sorting(arrc, k3);
   /* for (int i = 0; i < k3; i++)
        cout << arrc[i] << "; ";
    cout << endl;*/
    showArr(arrc, k3);
}

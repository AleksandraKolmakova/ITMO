#include <iostream>
using namespace std;

void showArray(const int [], const int);
bool fromMin(const int, const int);
bool fromMax(const int, const int);
void bubbleSort(int [], const int, bool (*compare)(int, int));

int main()
{
    int N = 0;
    cout << "Enter number of elements: ";
    cin >> N;
    int myChoose = 0;
    int* A = new int[N];

    //заполнение массива с клавиатуры
    for (int i = 0; i < N; i++)
    {
        cout << "mas[" << i << "]=";
        cin >> A[i];
    }
    
    bool (*fromF[2])(int, int) = { fromMin, fromMax };
    cout << "1. Sort ascending\n";
    cout << "2. Sort descending\n";
    cin >> myChoose;
    cout << "Basic data: ";
    showArray(A, N);

    //bubbleSort(A, N, (*fromF[myChoose - 1]));
    bubbleSort(A, N, (fromF[myChoose - 1]));
    cout << "Sorted data: ";
    showArray(A, N);

    delete[] A;
}

//вывод массива
void showArray(const int Arr[], const int N)
{
    for (int i = 0; i < N; i++)
        cout << Arr[i] << " ";
    cout << "\n";
}

//направление сравнения
bool fromMin(const int a, const int b)
{
    return a > b;
}
bool fromMax(const int a, const int b)
{
    return a < b;
}

//пузырьковая сортировка
void bubbleSort(int Arr[], const int N, bool (*compare)(int a, int b))
{
    for (int i = 1; i < N; i++)
    {
        for (int j = 0; j < N - 1; j++)
        {
            if ((*compare)(Arr[j], Arr[j + 1])) swap(Arr[j], Arr[j + 1]);
        }
    }
}

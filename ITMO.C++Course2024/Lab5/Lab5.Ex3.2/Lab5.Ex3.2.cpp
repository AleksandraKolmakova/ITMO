#include <iostream>
using namespace std;

void showArray(const int [], const int);
bool fromMin(const int, const int);
bool fromMax(const int, const int);
void bubbleSort(int [], const int, bool (*compare)(int, int));

int main()
{
    const int N = 10;
    int myChoose = 0;
    int A[N] = { 9, 8, 7, 6, 1, 2, 3, 5, 4, 9 };
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
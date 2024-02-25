#include <iostream>
using namespace std;

int main()
{
    const int n = 5; //размер массива
    int mas[n]; //массив целых числе размером n

    //заполнение массива с клавиатуры
    for (int i = 0; i < n; i++)
    {
        cout << "mas[" << i << "]=";
        cin >> mas[i];
    }

    // сумма всех элементов массива
    int sum = 0;
    for (int i = 0; i < n; i++)
    {
        sum += mas[i];
    }
    cout << "The sum of all elements of the array is: " << sum << endl;

    //среднее значение элементов массива
    double averige = double(sum) / n;
    cout << "The averige value of the array elements is: " << averige << endl;

    //расчет суммы отрицательных элементов массива
    int negSum = 0;
    for (int i = 0; i < n; i++)
    {
        if (mas[i] < 0) {
            negSum += mas[i];
        }
    }
    cout << "The sum of negative element of the array is: " << negSum << endl;

    //расчет суммы положительных элементов массива
    int posSum = 0;
    for (int i = 0; i < n; i++)
    {
        if (mas[i] > 0) {
            posSum += mas[i];
        }
    }
    cout << "The sum of positive elements of the array is: " << posSum << endl;

    //расчет суммы элеменmов с нечетными индексами
    int oddSum = 0;
    for (int i = 0; i < n; i++)
    {
        if (i % 2 != 0) {
            oddSum += mas[i];
        }
    }
    cout << "The sum of elements with odd indexes of the array is: " << oddSum << endl;

    //расчет суммы элеменmов с четными индексами
    int evenSum = 0;
    for (int i = 0; i < n; i++)
    {
        if (i % 2 == 0) {
            evenSum += mas[i];
        }
    }
    cout << "The sum of elements with even indexes of the array is: " << evenSum << endl;
    
    //max and min elements of array
    int maxElem = mas[0];
    for (int i = 0; i < n; i++)
    {
        if (mas[i] > maxElem)
        {
            maxElem = mas[i];
        }
    }

    int minElem = mas[0];
    for (int i = 0; i < n; i++)
    {
        if (mas[i] < minElem)
        {
            minElem = mas[i];
        }
    }

    cout << "Max and min elements of the array are: " << maxElem << " and " << minElem << endl;

    //произведение элементов между max and min elements of array
    /*int prod = 1;
    for (int i = minElem + 1; i <= maxElem; i++)
    {
        prod *= mas[i];
    }
    cout << "Product of elements between max and min elements of the array is: " << prod << endl;
    */
}


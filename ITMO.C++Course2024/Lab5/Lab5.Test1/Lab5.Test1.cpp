#include <iostream>
using namespace std;

int* enterArray(int);
void showArray(int[], const int);
void arrayDefinition(int[], const int);
void sortArray(int[], const int);

int main()
{
    const int n = 5; 
    int* mas = enterArray(n);

    showArray(mas, n);
    arrayDefinition(mas, n);
    sortArray(mas, n);
    showArray(mas, n);
    }
    
    //заполнение массива с клавиатуры
    int* enterArray(int n) {
        int* mas = new int[n];
        for (int i = 0; i < n; i++)
        {
            cout << "mas[" << i << "]=";
            cin >> mas[i];
        }
        return mas;
    }


    //вывод массива
    void showArray(int mas[], const int n)
    {
        for (int i = 0; i < n; i++)
            cout << mas[i] << " ";
        cout << "\n";
    }

    
    void arrayDefinition(int mas[], const int n)
    {
        //сумма
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
    }   

    //сортировка массива
    void sortArray(int mas[], const int n)
    {
        int min = 0;
        int buf = 0;

        for (int i = 0; i < n; i++)
        {
            min = i; // номер текущей ячейки, как ячейки с минимальным значением

            // поиск номера ячейки с минимальным значением
            for (int j = i + 1; j < n; j++)
                min = (mas[j] < mas[min]) ? j : min;

            // перестановка этого элемента, поменяв его местами с текущим
            if (i != min)
            {
                buf = mas[i];
                mas[i] = mas[min];
                mas[min] = buf;
            }
        }

    }
   


    


#include <iostream>
#include <fstream>
using namespace std;

int main()
{
    double sum = 0; //сумма чисел
    int const n = 100; //размер массива
    double nums[n]; //массив

    //заполняем массив случайными числами
    for (int i = 0; i < n; i++)
    {
        nums[i] = (rand() % 100);
    }

    ofstream out("test", ios::out | ios::binary);
    if (!out)
    {
        cout << "The file can't be opened\n";
        return 1;
    }

    //запись в поток из буфера, 
    // (char*)nums - указатель на буфер, sizeof(nums) заданное число байтов
    out.write((char*)nums, sizeof(nums));
    out.close();//закрыть поток

    //открытие файла
    ifstream in("test", ios::in | ios::binary);
    if (!in)
    {
        cout << "The file can't be opened\n";
        return 1;
    }

    //читаем и передаем в буфер
    in.read((char*)&nums, sizeof(nums));

    //обработка полученных данных
    int k = sizeof(nums) / sizeof(double);
    for (int i = 0; i < k; i++)
    {
        sum = sum + nums[i];
        cout << nums[i] << ' ';
    }
    cout << "\nsum = " << sum << endl;

    //закрываем поток
    in.close();
}

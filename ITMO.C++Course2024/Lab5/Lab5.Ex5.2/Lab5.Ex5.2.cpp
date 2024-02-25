#include <iostream>
#include <ctime>
#include <vector>
using namespace std;

int main()
{
    srand(time(NULL));
    int a, b, c;
    int k = 0; // кол-во неправильных ответов
    const int n = 10; // общее число вопросов
    int mas[n];
    vector<int> v1; //вектор для хранения целых чисел
    vector<int> v2;

    for (int i = 0; i < n; i++)
    {
        //инициализация a и b случайными числами по формуле 
        //r = min + rand() % (max-min+1)
        a = rand() % n + 1;
        b = rand() % n + 1;
        cout << a << " * " << b << " = ";
        cin >> c;
        mas[i] = c;

        if (a * b != c)
        {
            v2.push_back(c); //для добавления неправильного ответа в вектор
            k++;
            cout << "Error! ";
            cout << a << " * " << b << " = " << a * b << endl;
        }
        else 
        {
            v1.push_back(c); //для добавления правильного ответа в вектор
        }
    }

    cout << "\nAll: ";
    for (int i = 0; i < n; i++)
    {
        cout << mas[i] << " " << ends;
    }

    cout << "\nGood: ";
    for (int i = 0; i < v1.size(); i++)
    {
        cout << v1[i] << " " << ends;
    }

    cout << "\nBad: ";
    for (int i = 0; i < v2.size(); i++)
    {
        cout << v2[i] << " " << ends;
    }
}

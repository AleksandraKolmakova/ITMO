#include <iostream>
#include <ctime>
using namespace std;

int main()
{
    srand(time(NULL));
    int a, b, c;
    int k = 0; // кол-во неправильных ответов
    const int n = 10; // общее число вопросов
    int mas[n];

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
            k++; //k = k+1
            cout << "Error! ";
            cout << a << " * " << b << " = " << a * b << endl;
        }
    }

    cout << "\nAll: ";
    for (int i = 0; i < n; i++)
    {
        cout << mas[i] << " " << ends;
    }
    cout << "\nCount error: " << k << endl;
    return 0;
}

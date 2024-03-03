#include <iostream>
#include <windows.h>
using namespace std;

struct Distance
{
    int feet;
    double inches;
};

Distance AddDist(const Distance& d1, const Distance& d2)
{
    Distance d;
    d.feet = d1.feet + d2.feet;
    d.inches = d1.inches + d2.inches;
    if (d.inches >= 12.0)
    {
        d.inches -= 12.0;
        d.feet++;
    }
    return d;
}

Distance InputDist()
{
    Distance d;
    cout << "Enter feet and inches: ";
    cin >> d.feet >> d.inches;
    return d;
}

void ShowDist(Distance d)
{
    cout << d.feet << "\'-" << d.inches << "\"\n";
}

int main()
{
    Distance d1 = InputDist();
    Distance d2 = { 1, 6.25 };
    Distance d3 = AddDist(d1, d2);
    ShowDist(d1);
    ShowDist(d2);
    ShowDist(d3);
    //return 0;

    int n;
    cout << "Enter a size of the array: ";
    cin >> n;
    Distance* masDist = new Distance[n];
    //Вызов функции для ввода значений футов и дюймов
    for (int i = 0; i < n; i++)
    {
        masDist[i] = InputDist();
    }
    //Вызов функции вывода значений на экран
    for (int i = 0; i < n; i++)
    {
        ShowDist(masDist[i]);
    }

    delete[] masDist;
}

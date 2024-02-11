#include <iostream>
using namespace std;

int main()
{
    system("chcp 1251");
    double x1, y1, x2, y2, x3, y3, x4, y4, x5, y5;
    cout << "Введите координаты сторон пятиугольника: \n";
    cout << "x1, y1: \n";
    cin >> x1;
    cin >> y1;
    cout << "x2, y2: \n";
    cin >> x2;
    cin >> y2;
    cout << "x3, y3: \n";
    cin >> x3;
    cin >> y3;
    cout << "x4, y4: \n";
    cin >> x4;
    cin >> y4;
    cout << "x5, y5: \n";
    cin >> x5;
    cin >> y5;
    double x = 1 / 2.0 * (x1 * y2 + x2 * y3 + x3 * y4 + x4 * y5 + x5 * y1 - x2 * y1 - x3 * y2 - x4 * y3 - x5 * y4 - x1 * y5);
    cout << "\nx = " << abs(x) << endl;
    return 0;
}
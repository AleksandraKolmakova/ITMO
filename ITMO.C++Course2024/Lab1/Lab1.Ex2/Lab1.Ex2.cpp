#include <iostream>
#include <iomanip>
using namespace std;

int main()
{
    system("chcp 1251");
    string name;
    cout << "Введите свое имя\n";
    double a, b;
    cout << "Введите a и b: \n";
    cin >> a;
    cin >> name;
    cin >> b;
    double x = a / b;
    //int x = a / b;
    cout.precision(3);
    cout << "\nx = " << setprecision(3) << x << endl;
    cout << "Привет, " << name << "!\n";
    cout << sizeof(a / b) << endl << sizeof(x) << endl;
    return 0;
}
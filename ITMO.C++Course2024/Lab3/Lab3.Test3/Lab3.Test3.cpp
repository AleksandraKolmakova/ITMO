#include <iostream>
#include <math.h>
using namespace std;

double areaEqTr(double);
double areaVerTr(double, double, double);

int main()
{
    int num;
    double a, b, c;
    cout << "To calculate the area of an equilateral triangle, select 1\n";
    cout << "To calculate the area of a versatile triangle, select 2\n";
    cin >> num;
    if (num == 1)
    {
        cout << "Enter a side of triangle: ";
        cin >> a;
        cout << "The area of a equilateral triangle with the side " << a << " is: " << areaEqTr(a) << endl;
    }
    else if (num == 2)
    {
        cout << "Enter sides of triangle: ";
        cin >> a >> b >> c;
        cout << "The area of a versatile triangle with sides " << a << ", " << b << ", " << c << " is: " << areaVerTr(a, b, c) << endl;
    }  
    else 
    {
        cout << "Error, select 1 or 2";
    }
}

double areaEqTr(double a)
{
    double areaEq = ((a*a) * sqrt(3) / 4);
    return areaEq;
}

double areaVerTr(double a, double b, double c)
{
    double per = a + b + c;
    double pper = per / 2;
    double areaVer = sqrt((pper * (pper - a) * (pper - b) * (pper - c)));
    return areaVer;
}
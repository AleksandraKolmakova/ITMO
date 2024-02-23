#include <iostream>
#include <math.h>
using namespace std;

double pow(double);
double powRec(double);

int main()
{
    double a;
    cout << "Enter any number: ";
    cin >> a;
    cout << pow(a) << endl;
    cout << powRec(a) << endl;
}

double pow(double a)
{
    double b = pow(a, 1.0 / 3);
    return b;
}

double powRec(double a)
{
    double y, y1;
    y = a;
    do {
        y1 = y;
        y = (a / (y1 * y1) + 2 * y1) / 3;
    }
    while (abs(y - y1) > 1 / 100000);
    return y;
}
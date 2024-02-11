#include <iostream>
#include <cmath>
using namespace std;

int main()
{
    double per;
    cout << "Enter perimeter; \n";
    cin >> per;
    double a = per / 3;
    double pper = per / 2;
    double square = sqrt((pper * (pper - a) * (pper - a) * (pper - a)));
    cout << "\tSide\tSquare\n";
    cout << "\t" << a << "\t" << square << endl;
    return 0;
}
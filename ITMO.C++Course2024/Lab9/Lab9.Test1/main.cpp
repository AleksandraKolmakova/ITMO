#include <iostream>
#include "Triangle.h"
using namespace std;

int main()
{
    int side1, side2, side3;
    cout << "Enter the sides of the triangle; \n";
    cin >> side1 >> side2 >> side3;

    try {
        Triangle tr(side1, side2, side3);
        cout << "Square is: " << tr.square() << endl;
    }
    catch (WrongSideError error)
    {
        cout << "ERROR: ";
        error.printMesage();
        return 1; 
    }
    return 0;
}

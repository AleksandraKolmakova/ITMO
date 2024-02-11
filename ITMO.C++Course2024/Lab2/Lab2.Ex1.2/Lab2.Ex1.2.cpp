#include <iostream>
using namespace std;

int main()
{
    char op;
    cout << "Choose your dream car: ";
    cin >> op;

    switch (op)
    {    
    case 'V':
        cout << "Conditioner\n";
        //cout << "Radio\n";
        //cout << "Circle wheels\n";
        //cout << "Powerful engine\n";
        //break;
    case 'S':
        cout << "Radio\n";
        //cout << "Circle wheels\n";
        //cout << "Powerful engine\n";
        //break;
    default:
        cout << "Circle wheels\n";
        cout << "Powerful engine\n";
    }
}
#include <iostream>
using namespace std;

int Input(int&, int&);

int main()
{
    int a, b;
    if (Input(a, b) == false)
    {
        cerr << "error";
        return 1;
    }
    int s = a + b;
    return 0;
}

int Input(int& a, int& b) 
{
    cout << "Enter numbers a and b: ";
    cin >> a >> b;
    if (a > b)
    {
        return true;
    }
    else
    {
        return false;
    }
}
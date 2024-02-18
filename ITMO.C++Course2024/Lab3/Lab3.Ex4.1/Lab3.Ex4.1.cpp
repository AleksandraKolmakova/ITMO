#include <iostream>
using namespace std;

int addNumbers(int);
int addNumbers(int, int);

int main()
{
    int a, b;
    cout << "Enter any number: ";
    cin >> a;
    cout << addNumbers(a);
    cout << "\n" << "Enter any two numbers : ";
    cin >> a;
    cin >> b;
    cout << addNumbers(a, b);
}

int addNumbers(int n)
{
    if (n == 1) return 1; //выход из рекурсии
    else return (n + addNumbers(n - 1));
}

int addNumbers(int n, int m)
{
    if (n == m) return n; 
    else return (m + addNumbers(n, m - 1));
}


#include <iostream>
using namespace std;

int gcd(int, int);

int main()
{
    int a, b;
    cout << "Enter two numbers: " << "\n";
    cin >> a >> b;
    cout << gcd(a, b);
}

int gcd(int m, int n)
{
    if (n == 0) return m;
    return gcd(n, m % n);
}
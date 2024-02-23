#include <iostream>
using namespace std;

int recFunc(int);

int main()
{
    int a = 3;
    cout << recFunc(a) << endl;
}

int recFunc(int a)
{
    int n = 5;
    if (a == 0)
        return 0;
    return n * a + recFunc(a - 1);
}
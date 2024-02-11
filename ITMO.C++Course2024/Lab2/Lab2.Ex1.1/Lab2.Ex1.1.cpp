#include <iostream>
using namespace std;

int main()
{
    int x, y;
    cout << "Enter x and y: \n";
    cin >> x;
    cin >> y;
    if (x * x + y * y < 9 && y > 0)
        cout << "The point is inside\n";
    else if (x * x + y * y > 9 || y < 0)
        cout << "The point is outside\n";
    else 
        cout << "The point is at the border\n";
    return 0;
}
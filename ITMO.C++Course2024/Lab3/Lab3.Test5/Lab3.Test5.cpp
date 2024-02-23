#include <iostream>
using namespace std;

int findBinary(int);

int main()
{
    int num;
    cout << "Enter some decimal number : ";
    cin >> num;
    cout << "Binary number is: " << findBinary(num) << endl;
}

int findBinary(int decimal) {
    if (decimal == 0)
        return 0;
    else
        return decimal % 2 + 10 * (findBinary(decimal / 2));
}

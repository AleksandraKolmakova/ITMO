#include <iostream>
#include <vector>
#include <string>
using namespace std;

template<class T>
void Print(const T &data, string n)
{
    for (const auto& i : data) {
        if (i !=*data.begin()) {
            cout << n;
        }
        cout << i;
    }
    cout << endl;
}

int main()
{
    vector<int> data = { 1, 2, 3 };
    Print(data, ", "); //на экране: 1, 2, 3
}

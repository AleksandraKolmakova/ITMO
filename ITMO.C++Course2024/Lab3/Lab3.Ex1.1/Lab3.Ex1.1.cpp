#include <iostream>
#include<string>
using namespace std;

void privet(string);

int main()
{
    string name;
    cout << "What is your name?" << endl;
    cin >> name;
    //cout << name << ", " << "hello!" << endl;    
    privet(name);
    return 0;
}

void privet(string name)
{
    cout << name << ", " << "hello!" << endl;
}

#include <iostream>
#include <windows.h>
#include <string>
#include <tuple>
#include <vector>

using namespace std;

//функция епчати кортежа
void printTupleOfThree(tuple<string, int, double> t)
{
    cout << "("
        << get<0>(t) << ", "
        << get<1>(t) << ", "
        << get<2>(t) << ")" << endl;
}

int main()
{
    SetConsoleOutputCP(1251);
    SetConsoleCP(1251);

    //исходные данные для формирования кортежей
    vector<string> v1{ "one", "two", "three", "four", "five", "six" };
    vector<int> v2 = { 1, 2, 3, 4, 5, 6 };
    vector<double> v3 = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6 };
    //return 0;

    //создание переменной кортежа
    auto t0 = make_tuple(v1[0], v2[0], v3[0]);

    printTupleOfThree(t0);
}
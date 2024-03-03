#include <iostream>
#include <windows.h>
#include <string>
#include <tuple>
#include <vector>

using namespace std;
//typedef tuple<string, int, double> Tuple;
using Tuple = tuple<string, int, double>;
using Tuple2 = tuple<int, string>;

void printTupleOfThree(Tuple t)
{
    cout << "("
        << get<0>(t) << ", "
        << get<1>(t) << ", "
        << get<2>(t) << ")" << endl;
}

void printTupleOfTwo(Tuple2 t)
{
    cout << "("
        << get<0>(t) << ", "
        << get<1>(t) << ")" << endl;
}

Tuple funtup(string s, int a, double d)
{
    s.append("!");
    return make_tuple(s, a, d * 10);
}

Tuple changeTup(string s, int a, double d)
{
    s = s + " number";
    a = a * a;
    d = int(d);
    return make_tuple(s, a, d);
}

Tuple2 changeTup2(string s, int a, double d)
{
    s = s + " number";
    a = a * a;
    return make_tuple(a, s);
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
    auto t1 = funtup(v1[1], v2[1], v3[1]);
    auto t2 = changeTup(v1[1], v2[1], v3[1]);
    auto t3 = changeTup2(v1[1], v2[1], v3[1]);

    printTupleOfThree(t0);
    printTupleOfThree(t1);
    printTupleOfThree(t2);
    printTupleOfTwo(t3);
}


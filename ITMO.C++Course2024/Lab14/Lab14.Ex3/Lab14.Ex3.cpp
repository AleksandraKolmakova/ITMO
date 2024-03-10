#include <iostream>
#include <tuple>
#include <vector>
using namespace std;

template<class Tuple, size_t N>
struct TuplePrinter
{
    //рекурсивный экземпляр шаблона
    static void print(const Tuple& t)
    {
        TuplePrinter<Tuple, N - 1>::print(t);
        cout << ", " << get<N - 1>(t);
    }
};

template<class Tuple>
struct TuplePrinter<Tuple, 1>
{
    //рекурсивный экземпляр шаблона
    static void print(const Tuple& t)
    {
        cout << get<0>(t);
    }
};

//функция printTuple() вариативного шаблона, которая вызывает функцию-член
//print() класса TuplePrinter
template<class... Args>
void printTuple(const tuple<Args...>& t)
{
    cout << "\n(";
    TuplePrinter<decltype(t), sizeof...(Args)>::print(t);
    cout << ")";
}

int main()
{
    //исходные данные для формирования кортежей
    vector<string> v1{ "one", "two", "three", "four", "five", "six" };
    vector<int> v2 = { 1, 2, 3, 4, 5, 6 };
    vector<double> v3 = { 1.1, 2.2, 3.3, 4.4, 5.5, 6.6 };
    //return 0;

    //создание переменной кортежа
    auto t1 = make_tuple(v1[0], v1[1], v3[0]);
    printTuple(t1);

    auto t2 = make_tuple(v1[0], v1[1], v2[2], v3[0], v3[1]);
    printTuple(t2);

    return 0;
}

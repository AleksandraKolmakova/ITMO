﻿// Lab2.Ex3.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <ctime>
using namespace std;

int main()
{
    srand(time(NULL));
    int a, b, c;
    int k = 0; // кол-во неправильных ответов
    int n = 10; // общее число вопросов

    for (int i = 1; i <= n; i++)
    {
        //инициализация a и b случайными числами по формуле 
        //r = min + rand() % (max-min+1)
        a = rand() % n + 1;
        b = rand() % n + 1;
        cout << a << " * " << b << " = ";
        cin >> c;

        if (a * b != c)
        {
            k++; //k = k+1
            cout << "Error! ";
            cout << a << " * " << b << " = " << a * b << endl;
        }
    }
    cout << "Count error: " << k << endl;
    return 0;
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file

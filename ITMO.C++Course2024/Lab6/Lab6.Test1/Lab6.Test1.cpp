#include <iostream>
#include <fstream>
#include <string>

using namespace std;

int main()
{
    string text;
    ofstream out; // поток для записи
    out.open("Text.txt", ios::out); // открываем файл для записи
    getline(cin, text, '*'); // запись текста в переменную
    out << text; // запись текста в файл
    out.close(); // закрываем файл
}

//Twinkle, twinkle, little star,
//How I wonder what you are.
//Up above the world so high,
//Like a diamond in the sky.


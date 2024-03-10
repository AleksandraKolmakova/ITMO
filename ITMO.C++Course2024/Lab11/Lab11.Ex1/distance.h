#pragma once
#include <iostream>
using namespace std;

class Distance
{
private:
    int feet;
    float inches;
    const float MFT;
public:
    //конструктор по умолчанию
    Distance() : feet(0), inches(0.0), MFT(3.280833F) {}
    //конструктор с двумя параметрами
    Distance(int ft, float in) : feet(ft), inches(in), MFT(3.280833F) {}
    //конструктор для преобразования вещественного типа в тип Distance
    Distance(float meters) : MFT(3.280833F)
    {
        float fltfeet = MFT * meters; // перевод в футы
        feet = int(fltfeet); // число полных футов
        inches = 12 * (fltfeet - feet); // остаток - это дюймы
    }

    void getdist()
    {
        cout << "\nEnter foot: ";
        cin >> feet;
        cout << "\nEnter inches: ";
        cin >> inches;
    }

    void showdist()
    {
        cout << feet << "\' - " << inches << "\"\n";
    }
    friend std::ostream& operator<< (std::ostream& out, const Distance& dist);

    Distance operator+ (const Distance&) const;
    Distance operator- (const Distance&) const;
    Distance operator+ (float num) const;
    Distance operator- (float num) const;

    //операторная функция принимает значение объекта типа Distance 
    // и преобразовывет его во float
    operator float() const;
   
};


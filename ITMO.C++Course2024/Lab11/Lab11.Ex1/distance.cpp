#include <iostream>
#include "distance.h"
using namespace std;

Distance Distance::operator+(const Distance& d2) const
{
    int f = feet + d2.feet;
    float i = inches + d2.inches;
    if (i >= 12.0)
    {
        i -= 12.0;
        f++;
    }
    return Distance(f, i);
}

Distance Distance::operator+(float num) const
{
    Distance d = num;
    return *this + d;
}

Distance operator+(float num, const Distance& d2)
{
    return d2 + num;
}

Distance Distance::operator-(const Distance& d2) const
{
    //dist3 = dist1 - dist2;
    int f = feet - d2.feet;
    float i = inches - d2.inches;
    return Distance(f, i);
}

Distance Distance::operator- (float num) const
{
    Distance d = num;
    if ((feet > d.feet) || (feet == d.feet && inches >= d.inches))
    {
        return *this - d;
    }
    else return Distance();
}

Distance operator-(float val, const Distance& d)
{
    return Distance(val) - d;
}

//операторная функция принимает значение объекта типа Distance 
    // и преобразовывет его во float
Distance::operator float() const
{
    float fracfeet = inches / 12;
    fracfeet += static_cast<float>(feet);
    return fracfeet / MFT;
}

std::ostream& operator<< (std::ostream& out, const Distance& dist)
{
    out << dist.feet << "\' - " << dist.inches << "\"\n";
    return out;
}



#include <iostream>
#include "distance.h"
using namespace std;

int main()
{
    Distance dist1, dist2;
    dist1.getdist();
    dist2.getdist();
    Distance dist3 = dist1 - dist2;
    Distance dist4 = dist1 + dist2 + dist3;
    
    cout << "\ndist1 = ";
    dist1.showdist();
    cout << "\ndist2 = ";
    dist2.showdist();
    cout << "\ndist3 = ";
    dist3.showdist();
    cout << "\ndist4 = ";
    cout << dist4;

    Distance dist5 = 2.35F;
    float mtrs;
    mtrs = static_cast<float>(dist5); //используем оператор перевода в метры
    mtrs = dist2;
    cout << "\ndist5 = " << dist5;

    Distance dist6 = dist5 + dist1;
    cout << "\ndist6 = ";
    dist6.showdist();
    Distance dist7 = dist1 + dist5;
    cout << "\ndist7 = ";
    dist7.showdist();
    Distance dist8 = dist5 - dist1;
    cout << "\ndist8 = ";
    dist8.showdist();
    Distance dist9 = dist1 - 1.25F;
    cout << "\ndist9 = ";
    dist9.showdist();
}
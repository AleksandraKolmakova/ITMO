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
    //����������� �� ���������
    Distance() : feet(0), inches(0.0), MFT(3.280833F) {}
    //����������� � ����� �����������
    Distance(int ft, float in) : feet(ft), inches(in), MFT(3.280833F) {}
    //����������� ��� �������������� ������������� ���� � ��� Distance
    Distance(float meters) : MFT(3.280833F)
    {
        float fltfeet = MFT * meters; // ������� � ����
        feet = int(fltfeet); // ����� ������ �����
        inches = 12 * (fltfeet - feet); // ������� - ��� �����
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

    //����������� ������� ��������� �������� ������� ���� Distance 
    // � �������������� ��� �� float
    operator float() const;
   
};


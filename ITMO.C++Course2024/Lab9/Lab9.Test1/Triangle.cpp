/* Triangle.cpp */
#include "Triangle.h"
#include <iostream>
#include <math.h>

//Конструктор принимает и сохраняет значения в переменные класса
Triangle::Triangle(int side1, int side2, int side3)
{ 
        if (side1 + side2 < side3 || side1 + side3 < side2 || side3 + side2 < side1) 
        {
            throw WrongSideError();
        }
            Triangle::set_side1(side1);
            Triangle::set_side2(side2);
            Triangle::set_side3(side3);
   
}

//Установка
void Triangle::set_side1(int s1)
{
    Triangle::side1 = s1;
}

void Triangle::set_side2(int s2)
{
    Triangle::side2 = s2;
}

void Triangle::set_side3(int s3)
{
    Triangle::side3 = s3;
}

////Получение
int Triangle::get_side1()
{
	return Triangle::side1;
}

int Triangle::get_side2()
{
    return Triangle::side2;
}

int Triangle::get_side3()
{
    return Triangle::side3;
}

double Triangle::square()
{
    double pper = double(Triangle::side1 + Triangle::side2 + Triangle::side3) / 2;
    return sqrt((pper * (pper - Triangle::side1) * (pper - Triangle::side2) * (pper - Triangle::side3)));
}




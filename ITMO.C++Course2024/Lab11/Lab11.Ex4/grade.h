#pragma once
#include <iostream>
#include <string>
#include <vector>
using namespace std;

struct StudentGrade
{
    string name;
    char grade;
};

//класс-контейнер на основе вектора
class GradeMap
{
private:
    vector<StudentGrade>m_map;
public:
    GradeMap() {}

    //функция (прототип) перегрузки оператора []
    //принимает имя как параметр, возвращает ссылку на оценку
    char& operator[](const string& name);
};


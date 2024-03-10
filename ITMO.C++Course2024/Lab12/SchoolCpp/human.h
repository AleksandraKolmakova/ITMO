//human.h
#include<string>
#include<sstream>
#pragma once

using namespace std;

class human
{
public:
	//конструктор класса human
	human(string last_name, string name, string second_name)
	{
		this->last_name = last_name;
		this->name = name;
		this->second_name = second_name;
	}
	//получение ФИО человека
	string get_full_name()
	{
		ostringstream full_name;
		full_name << this->last_name << " "
			<< this->name << " "
			<< this->second_name;
		return full_name.str();
	}
private:
	string last_name;
	string name;
	string second_name;
};


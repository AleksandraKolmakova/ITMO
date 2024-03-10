//teacher.h
#include "human.h"
#include<string>
#pragma once

using namespace std;

class teacher : public human
{
	//конструктор класса teacher
public:
	teacher(string last_name, string name, string second_name, unsigned int work_time)
		: human(last_name, name, second_name)
	{
		this->work_time = work_time;
	}

	//Печать всех данных
	void print_full_data()
	{
		human::print_full_data();
		cout << "\nNumber of his work time is: " << get_work_time() << "hours";
	}

	//получение количества учебных часов
	unsigned int get_work_time()
	{
		return this->work_time;
	}
private:
	//учебные часы
	unsigned int work_time;
};
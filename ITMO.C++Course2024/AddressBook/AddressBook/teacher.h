//teacher.h
#include "human.h"
#include<string>
#pragma once

using namespace std;

class teacher : public human
{
	//конструкторы класса teacher
public:
	teacher() :human() {
		addRecord();
	}

	teacher(string last_name, string name, string phone, string lesson)
		: human(last_name, name)
	{
		this->phone =phone;
		this->lesson = lesson;
	}

	//получение данных учителя
	string get_full_data() override
	{
		return 
			"Teacher's name and last name are: " + human::get_full_data() + 
			"; Lesson: " + this->lesson + 
			"; Phone: " + this->phone + "\n";
	}

	teacher addRecord() {
		this->set_name();
		this->set_lastName();
		cout << "Enter a lesson: " << endl;
		cin >> lesson;
		cout << "Enter a phone: " << endl;
		cin >> phone;
		return teacher(human::get_lastName(), human::get_name(), phone, lesson);
	}

private:
	string phone;
	string lesson;
};

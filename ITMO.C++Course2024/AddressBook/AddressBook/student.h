#include "human.h"
#include<string>
#pragma once

using namespace std;

class student : public human
{
public:
	student() :human() {
		addRecord();
	}

	student(string last_name, string name, string phone, string faculty)
		: human(last_name, name)
	{
		this->phone = phone;
		this->faculty = faculty;
	}

	//получение данных студента
	string get_full_data() override
	{
		return "Student's name and last name are: " + human::get_full_data() +
			"; Faculty: " + this->faculty +
			"; Phone: " + this->phone + "\n";
	}

	student addRecord() {
		this->set_name();
		this->set_lastName();
		cout << "Enter a faculty: " << endl;
		cin >> faculty;
		cout << "Enter a phone: " << endl;
		cin >> phone;
		return student(human::get_lastName(), human::get_name(), phone, faculty);
	}

private:
	string phone;
	string faculty;
};
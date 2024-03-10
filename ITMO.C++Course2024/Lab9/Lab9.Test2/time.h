/* time.h */
#pragma once
#include <iostream>
#include<string>
using namespace std;

class Time
{
public:
	class TimeError {
	public:
		TimeError() : message("Wrong time") { };;
		void printMessage() const { cout << message << endl; };
	private:
		string message;
	};

	//Конструкторы класса Time
	Time(int, int, int);
	Time();
		
	//Установка часов, минут, секунд
	void set_hours(int);
	void set_minutes(int);
	void set_seconds(int);

	//Получение часов, минут, секунд
	int get_hours();
	int get_minutes();
	int get_seconds();
	
	void ShowTime();
	Time PlusTime(Time&);
	

private:
	int hours;
	int minutes;
	int seconds;
};

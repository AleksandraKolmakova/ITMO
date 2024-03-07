/* time.h */
#pragma once /*Защита от двойного подключения заголовочного файла*/
using namespace std;

class Time
{
public:
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

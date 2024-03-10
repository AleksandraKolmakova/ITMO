#include <iostream>
#include <windows.h>
#include "time.h"
using namespace std;

int main()
{
	int hours;
	int minutes;
	int seconds;
	float flHours = 1.25; 

	//Ввод времени с клавиатуры
	cout << "Enter hours : minutes : seconds " << "\n";

	try {
		Time time1 = Time(12, 40, 42);
		Time time2 = Time(10, 30, 22);
		Time time3;

		//Вывод данных на экран
		cout << "\nFirst time is: ";
		time1.ShowTime();
		cout << "\nSecond time is: ";
		time2.ShowTime();

		time3 = time1.PlusTime(time2);
		cout << "\nSum of first and secont time is: ";
		time3.ShowTime();
				
		Time time4 = time1 + time2;
		cout << "\nSum of first and secont time is: ";
		time4.ShowTime();
		Time time5 = time1 - time2;
		cout << "\nDifferent between first and secont time is: ";
		time5.ShowTime();

		cout << "\nCompare first and secont time: ";
		Time time6 = time1 = time2;

		cout << "\n\nSum of first time and 1,25 hours is: ";
		Time time7 = time1 + flHours;
		time7.ShowTime();
		cout << "\nSum of 1,25 hours and first time is: ";
		Time time8 =  flHours + time1;
		time8.ShowTime();
	}

	catch (Time::TimeError& err) {
		cout << "ERROR: ";
		err.printMessage();
	}

	
}

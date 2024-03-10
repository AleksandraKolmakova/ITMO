#include <iostream>
#include <windows.h>
#include "time.h"
using namespace std;

int main()
{
	int hours;
	int minutes;
	int seconds;

	//Ввод времени с клавиатуры
	cout << "Enter hours : minutes : seconds " << "\n";

	try {
	cin >> hours >> minutes >> seconds;
	Time time1 = Time(hours, minutes, seconds);
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
	}

	catch (Time::TimeError& err) {
		cout << "ERROR: ";
		err.printMessage();
	}
}
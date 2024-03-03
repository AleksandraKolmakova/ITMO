/* student.h */
#pragma once /*Защита от двойного подключения заголовочного файла*/
#include <string>
using namespace std;

class Student
{
public:
	//Запись данных о студенте в файл
	void save();

	//Деструктор класса Student, который вызывает метод записи данных в файл
	~Student();

	//Конструктор класса Student
	Student(string, string);

	//Установка имени студента
	void set_name(string);
	
	//Получение имени студента
	string get_name();
	
	//Установка фамилии студента
	void set_last_name(string);
	
	//Получение фамилии студента
	string get_last_name();
	
	//Установка промежуточных оценок
	void set_scores(int[]);
	
	//Установка среднего балла
	void set_average_sores(double);

	//Получение среднего балла
	double get_average_score();
	
private:
	int scores[5];
	double average_score;
	string name;
	string last_name;
};

#include <iostream>
#include <string>
#include "student.h"
using namespace std;

int main()
{
	string name;
	string last_name;
	IdCard idc(123, "Base");

	//Ввод имени с клавиатуры
	cout << "Name: ";
	getline(cin, name);
	//Ввод фамилии с клавиатуры
	cout << "Last name: ";
	getline(cin, last_name);

	//Передача параметров конструктору
	Student* student02 = new Student(name, last_name, &idc);

	//Оценки
	int scores[5];
	//Сумма всех оценок
	int sum = 0;
	//Ввод промежуточных оценок
	for (int i = 0; i < 5; ++i)
	{
		cout << "Score " << i + 1 << ": ";
		cin >> scores[i];
		//Суммирование
		sum += scores[i];
	}

	//Сохранение промежуточных оценок в объект класса Student
	student02->set_scores(scores);

	//Расчет среднего балла
	double average_score = sum / 5.0;
	//Сохранение среднего балла в объект класса Student
	student02->set_average_sores(average_score);

	//Вывод данных на экран
	cout << "Average ball for " << student02->get_name() << " "
		<< student02->get_last_name() << " is "
		<< student02->get_average_score() << endl;
	cout << "IdCard: " << student02->getIdCard().getNumber() << endl;
	cout << "Category: " << student02->getIdCard().getCategory() << endl;

	//Освобождение памяти
	delete student02;
	return 0;
}
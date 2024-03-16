//main.cpp
#include<iostream>
#include<vector>
#include"human.h"
#include"student.h"
#include"teacher.h"

using namespace std;

int main()
{
	//оценки студента
	vector<int> scores;
	//добавление оценок студента в вектор
	scores.push_back(5);
	scores.push_back(3);
	scores.push_back(4);
	scores.push_back(4);
	scores.push_back(5);
	scores.push_back(3);
	scores.push_back(3);
	scores.push_back(3);
	scores.push_back(3);

	//создание студента Петрова И.А.
	human* stud = new student("Petrov", "Ivan", "Alekseevich", scores);
	//вывод на экран ФИО студента и среднего балла студента
	cout << "Student's full name is: ";
	stud->print_full_data();


	//количество учебных часов
	unsigned int teacher_work_time = 40;
	//создание учителя Сергеева Д.С.
	human* tch = new teacher("Segreev", "Dmitriy", "Sergeevich", teacher_work_time);
	//вывод на экран ФИО учителя и количество учебных часов
	cout << "\nTeacher's full name is: "; 
	tch->print_full_data();
	
	return 0;
}
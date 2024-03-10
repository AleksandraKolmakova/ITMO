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
	student* stud = new student("Petrov", "Ivan", "Alekseevich", scores);
	//вывод на экран ФИО студента
	cout << "Student's full name is: " << stud->get_full_name() << endl;
	//вывод стреднего балла студента
	cout << "Student's average score is: " << stud->get_average_score() << endl;


	//количество учебных часов
	unsigned int teacher_work_time = 40;
	//создание учителя Сергеева Д.С.
	teacher* tch = new teacher("Segreev", "Dmitriy", "Sergeevich", teacher_work_time);
	//вывод на экран ФИО учителя и количество учебных часов
	cout << "\nTeacher's full name is: " << tch->get_full_name() << endl;
	cout << "Number of his work time is: " << tch->get_work_time() << " hours" << endl;
	return 0;
}
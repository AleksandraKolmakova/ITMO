#include <iostream>
#include <string>
using namespace std;

class Student
{
public:
	class ExScore //класс иключений
	{
	public:
		string funcName; //для имени функции
		int errorValue; //для хранения ошибочного значения

		ExScore(string fn, int erv) {
			funcName = fn; //строка с именем виновника ошибки
			errorValue = erv; //сохраненное неправильное значение
		}
	};
	//Установка имени студента
	void set_name(string student_name)
	{
		name = student_name;
	}

	//Получение имени студента
	string get_name()
	{
		return Student::name;
	}

	//Установка фамилии студента
	void set_last_name(string student_last_name)
	{
		last_name = student_last_name;
	}

	//Получение фамилии студента
	string get_last_name()
	{
		return last_name;
	}

	//Установка промежуточных оценок
	void set_scores(int student_scores[])
	{
		for (int i = 0; i < 5; ++i)
		{
			if (student_scores[i] > 5)
				throw ExScore("In function set_scores()", student_scores[i]);
			scores[i] = student_scores[i];
		}
	}

	//Установка среднего балла
	void set_average_sores(double ball)
	{
		average_score = ball;
	}

	//Получение среднего балла
	double get_average_score()
	{
		return average_score;
	}

private:
	int scores[5];
	double average_score;
	string name;
	string last_name;
};

int main()
{
	//Создание объекта класса Student
	Student student01;
	string name;
	string last_name;
	int scores[5];

	//Ввод имени с клавиатуры
	cout << "Name: ";
	getline(cin, name);
	//Ввод фамилии с клавиатуры
	cout << "Last name: ";
	getline(cin, last_name);

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

	//Передача введенных данных set-функциям для сохранения в закрытые переменные класса
	student01.set_name(name);
	student01.set_last_name(last_name);

	try {
		student01.set_scores(scores);
		//Расчет среднего балла
		double average_score = sum / 5.0;

		//Сохранение среднего балла в объект класса Student
		student01.set_average_sores(average_score);

		//Вывод данных на экран
		cout << "Average ball for " << student01.get_name() << " "
			<< student01.get_last_name() << " is "
			<< student01.get_average_score() << endl;
	}
	catch(Student::ExScore& ex)
	{
		cout << "\nInitialization error", ex.funcName;
		cout << "\nThe entered value " << ex.errorValue << " is invalid\n";
	}
	return 0;
}
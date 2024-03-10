#include <iostream>
#include <string>
using namespace std;

class Student
{
public:
	class ExScore //����� ���������
	{
	public:
		string funcName; //��� ����� �������
		int errorValue; //��� �������� ���������� ��������

		ExScore(string fn, int erv) {
			funcName = fn; //������ � ������ ��������� ������
			errorValue = erv; //����������� ������������ ��������
		}
	};
	//��������� ����� ��������
	void set_name(string student_name)
	{
		name = student_name;
	}

	//��������� ����� ��������
	string get_name()
	{
		return Student::name;
	}

	//��������� ������� ��������
	void set_last_name(string student_last_name)
	{
		last_name = student_last_name;
	}

	//��������� ������� ��������
	string get_last_name()
	{
		return last_name;
	}

	//��������� ������������� ������
	void set_scores(int student_scores[])
	{
		for (int i = 0; i < 5; ++i)
		{
			if (student_scores[i] > 5)
				throw ExScore("In function set_scores()", student_scores[i]);
			scores[i] = student_scores[i];
		}
	}

	//��������� �������� �����
	void set_average_sores(double ball)
	{
		average_score = ball;
	}

	//��������� �������� �����
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
	//�������� ������� ������ Student
	Student student01;
	string name;
	string last_name;
	int scores[5];

	//���� ����� � ����������
	cout << "Name: ";
	getline(cin, name);
	//���� ������� � ����������
	cout << "Last name: ";
	getline(cin, last_name);

	//����� ���� ������
	int sum = 0;
	//���� ������������� ������
	for (int i = 0; i < 5; ++i)
	{
		cout << "Score " << i + 1 << ": ";
		cin >> scores[i];
		//������������
		sum += scores[i];
	}

	//�������� ��������� ������ set-�������� ��� ���������� � �������� ���������� ������
	student01.set_name(name);
	student01.set_last_name(last_name);

	try {
		student01.set_scores(scores);
		//������ �������� �����
		double average_score = sum / 5.0;

		//���������� �������� ����� � ������ ������ Student
		student01.set_average_sores(average_score);

		//����� ������ �� �����
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
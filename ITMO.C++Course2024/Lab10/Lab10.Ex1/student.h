/* student.h */
#pragma once /*������ �� �������� ����������� ������������� �����*/
#include <string>
using namespace std;
#include "IdCard.h"

class Student
{
public:
	IdCard* iCard;
	void setIdCard(IdCard* c);
	IdCard getIdCard();

	//������ ������ � �������� � ����
	void save();

	//���������� ������ Student, ������� �������� ����� ������ ������ � ����
	~Student();

	//����������� ������ Student
	Student(string, string, IdCard*);

	//��������� ����� ��������
	void set_name(string);

	//��������� ����� ��������
	string get_name();

	//��������� ������� ��������
	void set_last_name(string);

	//��������� ������� ��������
	string get_last_name();

	//��������� ������������� ������
	void set_scores(int[]);

	//��������� �������� �����
	void set_average_sores(double);

	//��������� �������� �����
	double get_average_score();

private:
	int scores[5];
	double average_score;
	string name;
	string last_name;
};


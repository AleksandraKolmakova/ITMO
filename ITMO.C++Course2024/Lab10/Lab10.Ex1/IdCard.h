#pragma once
#include<string>
using namespace std;

class IdCard
{
public:
	//������������
	IdCard();
	IdCard(int);
	IdCard(int, string);

	//������ �������
	void setNumber(int newNumber);
	int getNumber();
	void setCategory(string category);
	string getCategory();

private:
	//����
	int numberIdCard;
	string categoryIdCard;
};
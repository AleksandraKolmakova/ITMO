#pragma once
#include<string>
using namespace std;

class IdCard
{
public:
	//конструкторы
	IdCard();
	IdCard(int);
	IdCard(int, string);

	//методы доступа
	void setNumber(int newNumber);
	int getNumber();
	void setCategory(string category);
	string getCategory();

private:
	//поля
	int numberIdCard;
	string categoryIdCard;
};
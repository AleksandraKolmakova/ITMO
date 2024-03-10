#include "IdCard.h"

IdCard::IdCard()
{
	numberIdCard = 0;
	categoryIdCard = "Not installed";
}

IdCard::IdCard(int n)
{
	numberIdCard = n;
	categoryIdCard = "Not installed";
}

IdCard::IdCard(int n, string cat)
{
	numberIdCard = n;
	categoryIdCard = cat;
}

void IdCard::setNumber(int newNumber)
{
	numberIdCard = newNumber;
}

int IdCard::getNumber()
{
	return numberIdCard;
}

void IdCard::setCategory(string category)
{
	categoryIdCard = category;
}

string IdCard::getCategory()
{
	return categoryIdCard;
}
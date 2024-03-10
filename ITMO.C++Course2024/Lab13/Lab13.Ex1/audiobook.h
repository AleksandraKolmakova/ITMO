#include"item.h"
#pragma once

class Audiobook : public Item
{
private:
	double time;
public:
	void getdata()
	{
		Item::getdata();
		cout << "\nEnter time of audiobook: ";
		cin >> time;
	}
	void putdata()
	{
		Item::putdata();
		cout << "\nThe time of audiobook is: " << time;
	}
};
#include"item.h"
#pragma once

class Paperbook : public Item
{
private:
	int pages;
public:
	void getdata()
	{
		Item::getdata();
		cout << "\nEnter count of paperbook's pages: ";
		cin >> pages;
	}
	void putdata()
	{
		Item::putdata();
		cout << "\nThe count of paperbook's pages is: " << pages;
	}
};

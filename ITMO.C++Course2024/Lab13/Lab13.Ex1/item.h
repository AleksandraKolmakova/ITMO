#include<iostream>
#include<string>
#include<windows.h>
#pragma once

using namespace std;

class Item
{
private:
	string title;
	double price;
public:
	virtual void getdata()
	{
		cout << "\nEnter the title: ";
		cin >> title;
		cout << "\nEnter the price: ";
		cin >> price;
	}
	virtual void putdata()
	{
		cout << "\nThe title is: " << title;
		cout << "\nThe price is: " << price;
	}
};

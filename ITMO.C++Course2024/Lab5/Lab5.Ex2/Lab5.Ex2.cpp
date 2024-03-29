﻿#include <iostream>
using namespace std;

int main()
{
	const int N = 10;
	int a[N] = { 1,25,6,32,43,5,96,23,4,55 }; 
	int min = 0;
	int buf = 0;

	for (int i = 0; i < N; i++)
	{
		min = i; // номер текущей ячейки, как ячейки с минимальным значением

		// поиск номера ячейки с минимальным значением
		for (int j = i + 1; j < N; j++)
			min = (a[j] < a[min]) ? j : min;

		// перестановка этого элемента, поменяв его местами с текущим
		if (i != min)
		{
			buf = a[i];
			a[i] = a[min];
			a[min] = buf;
		}
	}

	for (int i : a)
		cout << i << '\t';
}

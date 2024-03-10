﻿#include <iostream>
using namespace std;

void fun_value(double k, double x, double y)
{
	x = x + k;
	y = y + k;
}

void fun_prt(double k, double *x, double *y)
{
	*x = *x + k;
	*y = *y + k;
}

void fun_ref(double k, double &x, double &y)
{
	x = x + k;
	y = y + k;
}

void print(double x, double y)
{
	cout << "x = " << x << "; y = " << y << endl;
}

int main()
{
	double k = 2.5;
	double xv = 10;
	double yv = 10;

	print(xv, yv);

	fun_value(k, xv, yv);
	print(xv, yv);

	fun_prt(k, &xv, &yv);
	print(xv, yv);

	fun_ref(k, xv, yv);
	print(xv, yv);

	return 0;
}
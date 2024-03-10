/* Triangle.h */
#pragma once
#include <iostream>
#include <string>
using namespace std;

class Triangle
{
public:
	void set_side1(int);
	void set_side2(int);
	void set_side3(int);
	int get_side1();
	int get_side2();
	int get_side3();

	Triangle(int, int, int);
	double square();

private:
	int side1;
	int side2;
	int side3;
};

class WrongSideError //класс иключений
{
public:
	WrongSideError() : message("Wrong sides") { };
	void printMesage() const { cout << message << endl; };
private:
	string message;
};


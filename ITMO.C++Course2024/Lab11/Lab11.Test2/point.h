#pragma once
#include <iostream>
using namespace std;

class Point {
public:
	Point(double, double);
	Point();
	bool operator> (const Point&) const;
	bool operator< (const Point&) const;
	friend ostream& operator<< (ostream&, const Point&);
private:
	double posX;
	double posY;
	double distanceTo() const;
};

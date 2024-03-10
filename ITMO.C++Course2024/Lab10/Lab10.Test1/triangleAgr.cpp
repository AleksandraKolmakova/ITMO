#include <string>
#include "TriangleAgr.h"
#include "Dot.h"
#include <iomanip>

TriangleAgr::TriangleAgr(Dot* d1, Dot* d2, Dot* d3)
{
	set_dot1(d1);
	set_dot2(d2);
	set_dot3(d3);
}

void TriangleAgr::set_dot1(Dot* d)
{
	dot1 = d;
}

void TriangleAgr::set_dot2(Dot* d)
{
	dot2 = d;
}

void TriangleAgr::set_dot3(Dot* d)
{
	dot3 = d;
}

double TriangleAgr::Perimeter()
{
	double side1 = dot1->distanceTo(*dot2);
	double side2 = dot2->distanceTo(*dot3);
	double side3 = dot3->distanceTo(*dot1);
	return side1 + side2 + side3;
}
double TriangleAgr::Square()
{
	double side1 = dot1->distanceTo(*dot2);
	double side2 = dot2->distanceTo(*dot3);
	double side3 = dot3->distanceTo(*dot1);

	double pper = (side1 + side2 + side3) / 2;

	return sqrt(pper * (pper - side1) * (pper - side2) * (pper - side3));
}
void TriangleAgr::showSides()
{
	cout << "side1 - " << dot1->distanceTo(*dot2) << "; side2 - " << dot2->distanceTo(*dot3) << "; side3 - " << dot3->distanceTo(*dot1);
}
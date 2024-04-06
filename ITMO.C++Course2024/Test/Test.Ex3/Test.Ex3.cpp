#include <iostream>
using namespace std;

class Point {
private: int x, y;
public:
	Point() {
		x = 0;
		y = 0;
	}
	Point(int px, int py) {
		x = px;
		y = py;
	}
	Point operator+(Point& point) const {
		return Point(x + point.x, y + point.y);
	}

	Point operator+(int num) const{
		return Point(x + num, y + num);
	}

	void operator+= (Point& point) {
		*this = *this + point;
	}
};


int main()
{
	Point pt1(1, 1), pt2(2, 2), pt3;
	pt3 = pt1 + pt2;
	pt2 += pt1;
	pt3 = pt1 + 5;
}

#include <iostream>
#include <math.h>
using namespace std;

struct StructMyroot
{
	double x1;
	double x2;
};

StructMyroot Myroot(double a, double b, double c, int& flag);

int main()
{
	double a, b, c;
	int flag;
	StructMyroot root;

	cout << "Enter a, b, c: \n";
	cin >> a >> b >> c;

	root = Myroot(a, b, c, flag);
	if (flag == 1)
	{
		cout << "The roots of this equation are x1 = " << root.x1 << ", x2 = " << root.x2 << "." << endl;
	}
	else if (flag == 0)
	{
		cout << "The root of this equation is x1 = x2 = " << root.x1 << "." << endl;
	}
	else
	{
		cout << "There are no roots of this equation." << endl;
	}
}

StructMyroot Myroot(double a, double b, double c, int& flag)
{
	StructMyroot root;
	double D = pow(b, 2) - 4 * a * c;
	if (D > 0)
	{
		root.x1 = (-b - sqrt(D)) / (2 * a);
		root.x2 = (-b + sqrt(D)) / (2 * a);
		flag = 1;
	}
	else if (D == 0)
	{
		root.x1 = root.x2 = (-b) / (2 * a);
		flag = 0;
	}
	else
	{
		flag = -1;
	}
	return root;
}



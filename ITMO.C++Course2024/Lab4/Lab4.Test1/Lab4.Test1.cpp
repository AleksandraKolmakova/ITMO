#include <iostream>
#include <math.h>
using namespace std;

int Myroot(double, double, double, double&, double&);

int main()
{
	double a, b, c, x1, x2;
	cout << "Enter a, b, c: \n";
	cin >> a >> b >> c;
	if (Myroot(a, b, c, x1, x2) == 1)
	{
		cout << "The roots of this equation are x1 = " << x1 << ", x2 = " << x2 << "." << endl;
	}
	else if (Myroot(a, b, c, x1, x2) == 0)
	{
		cout << "The root of this equation is x1 = x2 = " << x1 << "." << endl;
	}
	else
	{
		cout << "There are no roots of this equation." << endl;
	}
}

int Myroot(double a, double b, double c, double& x1, double& x2)
{
	double D = pow(b, 2) - 4 * a * c;
	if (D > 0)
	{
		x1 = (-b - sqrt(D)) / (2 * a);
		x2 = (-b + sqrt(D)) / (2 * a);
		return 1;
	}
	else if (D == 0)
	{
		x1 = x2 = (-b) / (2 * a);
		return 0;
	}
	else
	{
		return -1;
	}
}


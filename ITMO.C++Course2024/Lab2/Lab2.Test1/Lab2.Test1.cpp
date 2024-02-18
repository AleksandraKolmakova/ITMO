#include <iostream> 
#include <math.h> 
using namespace std;

int main()
{
	int n, i, flag = 1;
	cout << "Enter a number: ";
	cin >> n;

	
	for (i = 2; i <= sqrt(n); i++) {
		if (n % i == 0) {
			flag = 0;
			break;
		}
	}

	if (n <= 1)
		flag = 0;

	if (flag == 1) {
		cout << n << " is a prime number";
	}
	else {
		cout << n << " is not a prime number";
	}

	return 0;
}

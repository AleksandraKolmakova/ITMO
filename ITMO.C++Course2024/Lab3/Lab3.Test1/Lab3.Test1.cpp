#include <iostream>
#include <string>
using namespace std;

int snilsFunc(string);

int main() {
	string snils = "";
	cout << "Enter your snils:\n";
	getline(cin, snils, '\n');
	cout << snilsFunc(snils);
}

int snilsFunc(string snils)
{
	string temp;
	snils.erase(remove(snils.begin(), snils.end(), '-'), snils.end());
	snils.erase(remove(snils.begin(), snils.end(), ' '), snils.end());
	int snilslength = snils.length();
	temp += snils[snils.length() - 2]; //9
	temp += snils[snils.length() - 1]; //1
	int controlNum = stoi(temp); //91
	int sum = 0;
	temp = "";

	for (int i = 0; i < snilslength; i++)
	{
		if (!isdigit(snils[i]))
		{
			cout << "Snils has unvalid simbols";
			return false;
		}
	}
	
	if (snilslength != 11) {
		cout << "Snils has too musch simbols";
		return false;
	}

	int k = 1;
	for (int i = snilslength - 3; i >= 0; i--)
	{
		int num = stoi(temp += snils[i]);
		num *= k;
		k++;
		temp = "";
		sum += num;
	}

	if (sum == 100 || sum == 101)
	{
		sum = 0;
	}
	else if (sum > 101)
	{
		sum %= 101;
		if (sum == 100)
		{
			sum = 0;
		}
	}

	if (sum != controlNum)
	{
		cout << "Your snils is not valid\n";
		return false;
	}
	else
	{
		cout << "Your snils is valid\n";
		return true;
	}
}
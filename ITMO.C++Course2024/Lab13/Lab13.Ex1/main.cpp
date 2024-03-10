#include"item.h"
#include"audiobook.h"
#include"paperbook.h"

using namespace std;

int main()
{
	//������ ���������� �� ����� item
	Item* bookarr[100];

	//���������� ������
	int n = 0;
	char choice;
	
	do {
		cout << "\nChoose audiobook or paperbook (a/p)";
		cin >> choice;
		if (choice == 'p')
			bookarr[n] = new Paperbook;
		else
			bookarr[n] = new Audiobook;
		bookarr[n++]->getdata();
		cout << "\nContinue (y/n)?";
		cin >> choice;
	} while (choice == 'y');

	//����� ������
	for (int j = 0; j < n; j++)
		bookarr[j]->putdata();
	cout << endl;
	return 0;
}
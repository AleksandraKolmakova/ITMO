#include <iostream>
#include <math.h>
using namespace std;

int main()
{
	int score = 0; // очки
	int shots = 0; // выстрелы
    
	while (score < 50){
		int x, y;
		cout << "Enter coordinates: ";
		cin >> x;
		cin >> y;
			
		double radius = sqrt((x*x) + (y*y));

		if (radius <= 1)
			score += 10;
		else if (radius <= 2)
			score += 5;
		else score = 0;
		shots++;
	} 
	
	cout << "Your score is: "<< score << "\n" << "Your did "<< shots << " shots" << endl;

	if (shots == 5)
		cout << "Our congratulations, your level is the highest!" << endl;
	else if (shots > 5 && score < 10)
		cout << "Our congratulations, your level is avarige!" << endl;
	
	else cout << "Our congratulations, your level is begginer!" << endl;
	
}

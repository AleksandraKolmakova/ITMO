#include <iostream>
using namespace std;

int transpositionMethod(int[], int, int);
void showArray(int[], int);

int main() {
    int mas[] = { 1,2,3,4,5,6,7,2 };
    int n = 8;
    cout << "Array: "; showArray(mas, n);

    int userValue;
    cout << "\nEnter some number from this array: ";
    cin >> userValue;

    for (int i = 0; i < n; i++) {
        cout << "Index number " << userValue << ": "
            << transpositionMethod(mas, n, userValue) << endl;
    }

    cout << "Array after using trensposition method: "; showArray(mas, n);
}

void showArray(int mas[], int n)
{
    for (int i = 0; i < n; i++)
        cout << mas[i] << " " << ends;
}

int transpositionMethod(int mas[], int n, int userValue) {
    int index;

    for (int i = 0; i < n; i++) {
        if (mas[i] == userValue) {
            index = i;
            if (index != 0) {
                swap(mas[i], mas[i - 1]);
            }
            return index;
        }
    }

    return 0;
}
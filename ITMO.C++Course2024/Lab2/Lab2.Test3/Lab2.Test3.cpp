#include <iostream>
using namespace std;
int main()
{
    double coinsValue[5] = { 0.5,1,2,5,10 };
    int coinsAmount = 0;   

    int coinsUsed[6];
    for (int i = 0; i < 5; i++)
        coinsUsed[i] = 0;

    double price;
    cout << "Enter your coin value: " << endl;
    cin >> price;
    while (price != 0)
    {
        for (int i = 4; i >= 0; i--)
        {
            if (price >= coinsValue[i])
            {
                price = price - coinsValue[i];
                coinsAmount++;
                coinsUsed[i]++;
                break;
            }
        }
    }

    cout << "Number of coins: " << coinsAmount << endl;
    for (int i = 0; i < 5; i++)
        cout << coinsUsed[i] << " coin value " << coinsValue[i] << endl;
    return 0;
}
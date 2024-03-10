#include <iostream>
#include <string>

using namespace std;

class DivideByZerroError
{
public:
    DivideByZerroError (): message ("Divide by zero") { }
    void printMesage() const { cout << message << endl; }
private:
    string message;
};

//функция реализующая операцию деления
float quotient(int num1, int num2)
{
    if (num2 == 0)
        throw DivideByZerroError();
    return (float)num1 / num2;
}

int main()
{
    cout << "Enter two integer numbers: \n";
    int number1, number2;
    cin >> number1 >> number2;

    try
    {
        float result = quotient(number1, number2);
        cout << "First number divides by second number is: " << result << endl;
    }
    catch (DivideByZerroError error)
    {
        cout << "ERROR: ";
        error.printMesage();
        return 1;  //завершение при ошибке
    }
    return 0; // нормальное завершение
}
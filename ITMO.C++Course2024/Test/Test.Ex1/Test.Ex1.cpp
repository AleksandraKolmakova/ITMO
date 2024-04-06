#include <iostream>
using namespace std;

class A {
public:
    A() {
        length = 0;
        myArr = new int[length];
    }

    ~A() {
        delete myArr;
    }

    A(int len) {
        length = len;
        myArr = new int[len];
        for (int i = 0; i < len; i++)
            myArr[i] = i;
    }
   
    int size() const{
        return length;
    }

    int& operator[] (int len) const
    {
        if (len < length)
            return myArr[len];
        else {
            cout << "\nArray out of range";
            exit(1);
        }
    }
private:
    int* myArr;
    int length;
};

int main()
{
    A a1;
    A a2(10);
    A a3 = a2;
    a1 = a3;
    a2 = A(20);
    const A a4(5);
    for (int i = 0; i < a2.size(); i++)
        {
            cout << a4[i];
        }
}

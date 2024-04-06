#include <iostream>
using namespace std;

class Stack {
public:
    int myArr[10];
    int length;
    Stack(){
    }

    void reset() {
        length = 0;
        for (int i = 0; i < 10; i++)
            myArr[i] = 0;
    }

    bool push(int val) {
        if (length >= 10)
            return false;
        else
            myArr[length] = val;
            length++;
            return true;
    }

    void pop() {
        if (length == 0) {
            cout << "Warning!";
        }
        else {
            --length;
        }
    }

    void print() {
        cout << "( ";
            for (int i = 0; i < length; i++) {
                cout << myArr[i] << " ";
            }
            cout << " )\n";
    }

};

int main()
{
    Stack stack;
    stack.reset();
    stack.print();
    stack.push(3);
    stack.push(7);
    stack.push(5);
    stack.print();
    stack.pop();
    stack.print();
    stack.pop();
    stack.pop();
    stack.print();
    return 0;
}

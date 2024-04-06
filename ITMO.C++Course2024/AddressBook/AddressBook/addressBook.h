#include<iostream>
#include<fstream>
#include<string>
#include<vector>
#include<windows.h>
#include<cstdlib>

#include"human.h"
#include"student.h"
#include"teacher.h"
#pragma once

using namespace std;

// Класс Адресная книга
class AddressBook
{
public:
    AddressBook() {}
    ~AddressBook() {}
    int runMenu()
    {
        cout << "Address Book\n" << endl;
        cout << "To enter a contact select 1" << endl;
        cout << "To show contacts select 2" << endl;
        cout << "To save contact select 3" << endl;
        cout << "To close the Address Book select 4" << endl;
        cout << "\nSelect a number:";
        int act;
        cin >> act;
        return act;
    }

    void runProgram()
    {
        system("cls");
        int action = runMenu();
        while (action < 1 || action > 4)
        {
            system("cls");
            action = runMenu();
        }
        switch (action)
        {
            case 1:
                system("cls");
                int val;
                cout << "If you want to enter a teacher selet 1" << endl;
                cout << "If you want to enter a student selet 2" << endl;
                cout << "If you want to go back select 3" << endl;
                cout << "\nSelect a number:";
                cin >> val;
                if (val == 1)
                {
                    teacher* tch = new teacher();
                    addBook.push_back(tch);
                    cout << "Contact added" << endl;
                    menuOne(0);

                }
                else if (val == 2)
                {
                    student* st = new student();
                    addBook.push_back(st);
                    cout << "Contact added" << endl;
                    menuOne(0);
                }
                else if (val == 3)
                    runProgram();
                else
                {
                    system("cls");
                    cout << "Error" << endl;
                    menuOne(0);
                }
                break;
            case 2:
            {
                system("cls");
                for (int i = 0; i < addBook.size(); i++)
                {
                    cout << addBook[i]->get_full_data();
                }
                menuOne(0);
                break;
            }
            case 3:
            {
                saveFile(addBook);
                break;
            }
        }
    }

    void saveFile(vector<human*> addBook)
    {
        ofstream file("Text.txt", ios::app);
        if (!file) {
            cout << "Error!" << endl;
        }
        for (const auto& item : addBook) {
            file << item->get_full_data() << endl;
        }
        cout << "\nContact saved" << endl;
        file.close();
        menuOne(0);
    }

    void menuOne(int value)
    {
        while (value < 1 || value > 2)
        {
            cout << "Go to the menu - enter 1" << endl;
            cout << "Exit - enter 2" << endl;
            cout << "Enter:";
            cin >> value;
        }
        if (value == 1)
            runProgram();
        else
            exit(0);
    }
private:
    vector<human*> addBook;
};


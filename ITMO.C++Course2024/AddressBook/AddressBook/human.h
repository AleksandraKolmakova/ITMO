//human.h
#include<string>
#include<sstream>
#pragma once

using namespace std;

class human
{
public:
    //конструкторы класса human
	human(){}
	
	human(string last_name, string name)
	{
		this->last_name = last_name;
		this->name = name;
	}

	//виртуальное получение данных о человеке
	virtual string get_full_data()
	{
		ostringstream full_name;
		full_name << this->last_name << " "
			<< this->name;
		return full_name.str();
	}

    string get_name()
    {
        return name;
    }
    string get_lastName()
    {
        return last_name;
    }

protected:
    void set_name()
    {
        string name;
        cout << "\nEnter a contact's name: " << endl;
        cin >> name;
        this->name = name;
    }
    void set_lastName()
    {
        string lastName;
        cout << "Enter a contact's last name:" << endl;
        cin >> lastName;
        this->last_name = lastName;
    }	

private:
	string last_name;
	string name;
};


#include <iostream>
#include <string>
#include <map>
#include "studentGrade.h"


int main() {
    const char grade5 = '5';
    const char grade4 = '4';
    const char grade3 = '3';

    const string nameMaria = "Maria";
    const string nameAnna = "Anna";
    const string nameBen = "Ben";
    const string nameJen = "Jen";

    StudentGrade maria(nameMaria, grade5);
    StudentGrade anna(nameAnna, grade4);
    StudentGrade ben(nameBen, grade3);
    StudentGrade jen(nameJen, grade5);

    map<string, char> Map;
    Map[maria.name] = maria.grade;
    Map[anna.name] = anna.grade;
    Map[ben.name] = ben.grade;
    Map[jen.name] = jen.grade;

    for (auto item = Map.begin(); item != Map.end(); ++item)
    {
        cout << item->first << "'s grade is: " << item->second << endl;
    }
}
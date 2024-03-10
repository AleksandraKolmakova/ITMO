#include "grade.h"
using namespace std;

char& GradeMap::operator[](const string& name)
{
	//find student's name in the map
	for (auto& ref : m_map)
	{
		//Если нашли, то возвращаем ссылку на его оценку
		if (ref.name == name)
			return ref.grade;
	}
	//Если нет, то создаем новый StudentGrade для нового ученика
	StudentGrade temp{ name, ' ' };
	//Помещаем его в конец вектора
	m_map.push_back(temp);
	//Возвращаем ссылку на его оценку
	return m_map.back().grade;
}
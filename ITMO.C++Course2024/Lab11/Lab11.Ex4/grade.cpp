#include "grade.h"
using namespace std;

char& GradeMap::operator[](const string& name)
{
	//find student's name in the map
	for (auto& ref : m_map)
	{
		//���� �����, �� ���������� ������ �� ��� ������
		if (ref.name == name)
			return ref.grade;
	}
	//���� ���, �� ������� ����� StudentGrade ��� ������ �������
	StudentGrade temp{ name, ' ' };
	//�������� ��� � ����� �������
	m_map.push_back(temp);
	//���������� ������ �� ��� ������
	return m_map.back().grade;
}
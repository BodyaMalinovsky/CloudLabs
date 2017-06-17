#include "Shedule.h"

Shedule::Shedule()
{
	count = 0;
}
void Shedule:: makeTask(int date, int mounth, int year, std::string name, std::string desc)
{
	tasklist[count] = Task();
	tasklist[count].setTask(date, mounth, year, name, desc);
	count++;
}
void Shedule::printAllTasks()
{
	for (int i = 0; i < count; i++)
	{
		tasklist[i].print();
	}
}
void Shedule::printTasksByName(std::string name)
{
	for (int i = 0; i < count; i++)
	{
		if (tasklist[i].findTasksByName(name))
			tasklist[i].print();
	}
}

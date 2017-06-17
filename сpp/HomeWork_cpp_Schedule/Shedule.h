#pragma once
#include "Task.h"
class Shedule
{
private:
	Task tasklist[255];
	int count;

public:
	Shedule();
	void makeTask(int date, int mounth, int year, std::string name, std::string desc);
	void printAllTasks();
	void printTasksByName(std::string name);
};
#pragma once
#include <iostream>

class Task
{
public:
	int Date;
	int Mounth;
	int Year;
	std::string Name;
	std::string Description;

public:
	Task();
	Task(int, int, int, std::string, std::string);
	bool findTasks(int, int, int);
	bool findTasksByName(std::string);
	void setTask(int,int,int,std::string, std::string);
	void print();
};
#pragma once
#include"Task.h"

	Task::Task()
	{
		Date = 1;
		Mounth = 1;
		Year = 2017;
		Description = "none";
		Name = "None";
	}

	Task::Task(int date, int mounth, int year, std::string name, std::string description)
	{
		setTask(date, mounth, year, name, description);
	}

	bool Task::findTasks(int date, int mounth, int year)
	{
		if (Mounth == mounth && Year == year && Date == date)
		{
			return true;
		}
		else return false;
	}

	bool Task::findTasksByName(std::string name)
	{
		if (Name == name) return true;
		else return false;
	}

	void Task::setTask(int day, int mounth, int year, std::string name, std::string description)
	{
		Date = day;
		Mounth = mounth;
		Year = year;
		Name = name;
		Description = description;
	}

	void Task::print()
	{
		std::cout << Date << "Day, " << Mounth << "Mounth, " << Year << "Year, " << Name.c_str() << "Name, " << Description.c_str() << "Description." << std::endl;
	}
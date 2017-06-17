#include <string>  
#include "Shedule.h"
int menu, day, mounth, year, newday, newmounth, newyear;
std::string name, newname, description, newdescription;
int main()
{
	Shedule shedule;
	for (;;)
	{
		std::cout << "Enter 1 for view shedule:" << std::endl;
		std::cout << "Enter 2 for add task:" << std::endl;
		std::cout << "Enter 3 for find by name:" << std::endl;
		std::cout << "Enter 4 for quit:" << std::endl;
		std::cout << std::endl;

		std::cin >> menu;
		if (menu == 1)
		{
			shedule.printAllTasks();
			system("pause");
		}
		else if (menu == 2)
		{
			system("cls");
			std::cout << "Day:" << std::endl;
			std::cin >> day;
			std::cout << "Mounth:" << std::endl;
			std::cin >> mounth;
			std::cout << "Year:" << std::endl;
			std::cin >> year;
			std::cout << "Name:" << std::endl;
			std::cin >> name;
			std::cout << "Description:" << std::endl;
			std::cin >> description;
			shedule.makeTask(day, mounth, year, name, description);
			system("pause");
		}		
		else if (menu == 3)
		{
			system("cls");
			std::cout << "Name:" << std::endl;
			std::cin >> name;
			shedule.printTasksByName(name);
			system("pause");
		}
		else if (menu == 4)
		{
			return 0;
		}
		else
		{
			system("cls");
		}
		system("cls");
	}
}
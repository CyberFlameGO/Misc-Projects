#include "Errors.h"

#include <iostream>
#include <Windows.h>
#include <stdlib.h>
#include <string>

int Errors::THROW(std::string MESSAGE)
{
	std::cout << "ERROR: " << MESSAGE << "\n" << std::endl;

	system("color 0c");
	system("pause");
	
	return 0;
}
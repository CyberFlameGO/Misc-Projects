#include "AutoClicker.h"

#include <Windows.h>
#include <iostream>
#include <fstream>
#include <string>
#include <sstream>

#include <direct.h>
#define GetCurrentDir _getcwd

bool TOGGLED = false;

int AutoClicker::getCPS()
{
	int CPS = 0;

	char BUFFER[FILENAME_MAX];
	GetCurrentDir(BUFFER, FILENAME_MAX);
	std::string DIR(BUFFER);
	std::string PATH = DIR + "\\console\\data.txt";

	std::ifstream FILE;
	FILE.open(PATH);

	std::string LINE;

	if (FILE.is_open())
	{
		while (std::getline(FILE, LINE))
		{
			if (LINE.find("CPS") != std::string::npos)
			{
				std::stringstream CONVERT(LINE.substr(4));
				CONVERT >> CPS;
			} 
		}

		FILE.close();
	}

	return CPS;
}

std::string AutoClicker::getMouseButton()
{
	std::string MB = "LEFT";

	char BUFFER[FILENAME_MAX];
	GetCurrentDir(BUFFER, FILENAME_MAX);
	std::string DIR(BUFFER);
	std::string PATH = DIR + "\\console\\data.txt";

	std::ifstream FILE;
	FILE.open(PATH);

	std::string LINE;

	if (FILE.is_open())
	{
		while (std::getline(FILE, LINE))
		{
			if (LINE.find("MOUSE_BUTTON") != std::string::npos)
				MB = LINE.substr(13);
		}

		FILE.close();
	}

	return MB;
}

int AutoClicker::getRepeat()
{
	int REPEAT = 0;

	char BUFFER[FILENAME_MAX];
	GetCurrentDir(BUFFER, FILENAME_MAX);
	std::string DIR(BUFFER);
	std::string PATH = DIR + "\\console\\data.txt";

	std::ifstream FILE;
	FILE.open(PATH);

	std::string LINE;

	if (FILE.is_open())
	{
		while (std::getline(FILE, LINE))
		{
			if (LINE.find("REPEAT") != std::string::npos)
			{
				std::stringstream CONVERT(LINE.substr(7));
				CONVERT >> REPEAT;
			}
		}

		FILE.close();
	}

	return REPEAT;
}

bool AutoClicker::isToggled() { return TOGGLED; }
void AutoClicker::setToggle(bool NEW_TOGGLE) { TOGGLED = NEW_TOGGLE; }

void AutoClicker::click()
{
	if (AutoClicker::getMouseButton() == "RIGHT")
	{
		mouse_event(MOUSEEVENTF_RIGHTDOWN, 0, 0, 0, 0);
		mouse_event(MOUSEEVENTF_RIGHTUP, 0, 0, 0, 0);
	}
	else
	{
		mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
		mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
	}
}

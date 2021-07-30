#include <iostream>
#include <stdlib.h>
#include <Windows.h>

#include "AutoClicker.h"

struct Selection {
	void SELECT_TOGGLE_ON_KEY()
	{
		std::cout << "Toggle On Key: ";
		char TOGGLE_ON_KEY;
		std::cin >> TOGGLE_ON_KEY;
		AutoClicker::setToggleOnKey(TOGGLE_ON_KEY);
	};

	void SELECT_TOGGLE_OFF_KEY()
	{
		std::cout << "Toggle Off Key: ";
		char TOGGLE_OFF_KEY;
		std::cin >> TOGGLE_OFF_KEY;
		AutoClicker::setToggleOffKey(TOGGLE_OFF_KEY);
	};

	void SELECT_MIN_CPS()
	{
		std::cout << "Enter minimum CPS: ";
		int MIN_CPS;
		std::cin >> MIN_CPS;
		AutoClicker::setMinCPS(MIN_CPS);
	};

	void SELECT_MAX_CPS()
	{
		std::cout << "Enter maximum CPS: ";
		int MAX_CPS;
		std::cin >> MAX_CPS;
		AutoClicker::setMaxCPS(MAX_CPS);
	};
};

int main()
{
	system("color 0f");
	system("title AutoClicker v2.0");

	std::cout << "AutoClicker v2.0 by Yochran has loaded.\n" << std::endl;

	Selection selection;

	selection.SELECT_TOGGLE_ON_KEY();
	selection.SELECT_TOGGLE_OFF_KEY();

	std::cout << "Toggle keys have been set.\n" << std::endl;

	selection.SELECT_MIN_CPS();
	selection.SELECT_MAX_CPS();

	std::cout << "CPS has been set.\n" << std::endl;
	std::cout << "To toggle on, press the toggle on key. To toggle off, press the toggle off key." << std::endl;
	std::cout << "To start clicking, click your left mouse button once." << std::endl;

	while (true)
	{
		if (GetAsyncKeyState('Q'))
		{
			AutoClicker::setToggle(true);
			system("color 0a");
		}

		if (GetAsyncKeyState('Z'))
		{
			AutoClicker::setToggle(false);
			system("color 0f");
		}

		if (GetAsyncKeyState(RI_MOUSE_LEFT_BUTTON_DOWN) && AutoClicker::isToggled())
		{
			AutoClicker::click();
			Sleep((1000 / AutoClicker::getRandomCPS()));
			AutoClicker::generateNewRandomCPS();
		}

	}

	system("pause");
	return 0;
}

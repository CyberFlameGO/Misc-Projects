#include <iostream>
#include <Windows.h>
#include <stdlib.h>
#include <fstream>

#include "AutoClicker.h"

int main()
{
    system("color 0f");
    system("title Clicker");

	std::cout << "CPS: " << AutoClicker::getCPS() << std::endl;
	std::cout << "MOUSE_BUTTON: " << AutoClicker::getMouseButton() << std::endl;
	std::cout << "REPEAT: " << AutoClicker::getRepeat() << std::endl;

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
			system("color 04");
		}

		if (AutoClicker::isToggled())
		{
			if (AutoClicker::getRepeat() == 0)
			{
				AutoClicker::click();
				Sleep((1000 / AutoClicker::getCPS()));
				continue;
			}
			else
			{
				for (int i = 0; i < AutoClicker::getRepeat(); i++)
				{
					AutoClicker::click();
					Sleep((1000 / AutoClicker::getCPS()));
				}

				break;
				break;
			}
		}
	}

	system("color 0f");
    system("pause");
    return 0;
}

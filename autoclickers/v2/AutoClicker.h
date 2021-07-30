#ifndef AUTOCLICKER_H
#define AUTOCLICKER_H

#include <stdlib.h>
#include <string>

class AutoClicker
{
	public:
		static int getCPS();
		static std::string getMouseButton();

		static int getRepeat();

		static bool isToggled();
		static void setToggle(bool NEW_TOGGLE);

		static void click();
};

#endif


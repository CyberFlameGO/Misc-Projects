#ifndef AUTOCLICKER_H
#define AUTOCLICKER_H

class AutoClicker
{
	public:
		static char getToggleOnKey();
		static void setToggleOnKey(char NEW_TOGGLE_ON_KEY);

		static char getToggleOffKey();
		static void setToggleOffKey(char NEW_TOGGLE_OFF_KEY);

		static int getMinCPS();
		static void setMinCPS(int NEW_MIN_CPS);

		static int getMaxCPS();
		static void setMaxCPS(int NEW_MAX_CPS);

		static int getRandomCPS();
		static void generateNewRandomCPS();

		static bool isToggled();
		static void setToggle(bool NEW_TOGGLE);

		static void click();
};

#endif


#include <Windows.h>

#include "AutoClicker.h"

char TOGGLE_ON_KEY = 'Q';
char TOGGLE_OFF_KEY = 'Z';

int MIN_CPS = 10;
int MAX_CPS = 10;
int RANDOM_CPS = 10;

bool TOGGLED = false;

char AutoClicker::getToggleOnKey() { return TOGGLE_ON_KEY; }
void AutoClicker::setToggleOnKey(char NEW_TOGGLE_ON_KEY) { TOGGLE_ON_KEY = toupper(NEW_TOGGLE_ON_KEY); }

char AutoClicker::getToggleOffKey() { return TOGGLE_OFF_KEY; }
void AutoClicker::setToggleOffKey(char NEW_TOGGLE_OFF_KEY) { TOGGLE_OFF_KEY = toupper(NEW_TOGGLE_OFF_KEY); }

int AutoClicker::getMinCPS() { return MIN_CPS; }
void AutoClicker::setMinCPS(int NEW_MIN_CPS) { MIN_CPS = NEW_MIN_CPS; }

int AutoClicker::getMaxCPS() { return MAX_CPS;  }
void AutoClicker::setMaxCPS(int NEW_MAX_CPS) { MAX_CPS = NEW_MAX_CPS; }

int AutoClicker::getRandomCPS() { return RANDOM_CPS;  }
void AutoClicker::generateNewRandomCPS() {
	int NEW_RANDOM_CPS = rand() % AutoClicker::getMaxCPS() + AutoClicker::getMinCPS();
	RANDOM_CPS = NEW_RANDOM_CPS;
}

bool AutoClicker::isToggled() { return TOGGLED; }
void AutoClicker::setToggle(bool NEW_TOGGLE) { TOGGLED = NEW_TOGGLE; }

void AutoClicker::click() 
{
	mouse_event(MOUSEEVENTF_LEFTDOWN, 0, 0, 0, 0);
	mouse_event(MOUSEEVENTF_LEFTUP, 0, 0, 0, 0);
}

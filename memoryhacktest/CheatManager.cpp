#include "CheatManager.h"

#include <Windows.h>
#include <stdlib.h>
#include <string>

#include "Feed.h"

bool LISTENING = false;

bool CheatManager::IS_LISTENING() { return LISTENING; }

void CheatManager::START_LISTENING() { LISTENING = true; }
void CheatManager::STOP_LISTENING() { LISTENING = false; }

bool CheatManager::RUN(std::string CHEAT, HANDLE HANDLE)
{
	bool FINISHED = false;

	if (CHEAT == "FEED")
	{
		int CURRENT_AMOUNT;
		ReadProcessMemory(HANDLE, (LPVOID) 0xDC3eFCC4, &CURRENT_AMOUNT, sizeof(CURRENT_AMOUNT), 0);

		int FEED_AMOUNT = CURRENT_AMOUNT + Feed::GET_AMOUNT();
		WriteProcessMemory(HANDLE, (LPVOID) 0xDC3eFCC4, &FEED_AMOUNT, sizeof(FEED_AMOUNT), 0);

		FINISHED = true;
	}

	return FINISHED;
}
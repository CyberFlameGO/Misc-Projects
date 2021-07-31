#include "Game.h"

#include <Windows.h>
#include <stdlib.h>

struct GameStructure
{
	LPCSTR TITLE = "Minecraft 1.7.10";
};

LPCSTR Game::GET_TITLE()
{
	GameStructure GAME_STRUCTURE;
	return GAME_STRUCTURE.TITLE;
}

HWND Game::GET_WINDOW(LPCSTR TITLE) 
{ 
	return FindWindowA(NULL, TITLE);
}

DWORD Game::GET_PROCESS(HWND WINDOW)
{
	DWORD PROCESS;
	GetWindowThreadProcessId(WINDOW, &PROCESS);

	return PROCESS;
}

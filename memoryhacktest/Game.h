#ifndef GAME_H
#define GAME_H

#pragma once

#include <Windows.h>
#include <stdlib.h>

class Game
{
	public:
		static LPCSTR GET_TITLE();

		static HWND GET_WINDOW(LPCSTR TITLE);
		static DWORD GET_PROCESS(HWND WINDOW);
};

#endif


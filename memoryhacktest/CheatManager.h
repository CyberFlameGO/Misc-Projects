#ifndef CHEATMANAGER_H
#define CHEATMANAGER_H

#pragma once

#include <Windows.h>
#include <stdlib.h>
#include <string>

class CheatManager 
{
	public:
		static bool IS_LISTENING();
		static void START_LISTENING();
		static void STOP_LISTENING();

		static bool RUN(std::string CHEAT, HANDLE HANDLE);
};

#endif

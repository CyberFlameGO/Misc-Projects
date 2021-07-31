#include <iostream>
#include <Windows.h>
#include <stdlib.h>
#include <string>

#include "Game.h"
#include "CheatManager.h"
#include "Errors.h"

int main()
{
    system("color 0f");
    system("title Minecraft Memory Hack Tester");

    std::cout << "Minecraft Memory Hack Tester is loading..." << std::endl;
    CheatManager::START_LISTENING();

    HWND H_WINDOW = Game::GET_WINDOW(Game::GET_TITLE());

    if (H_WINDOW == NULL)
    {
        return Errors::THROW("Couldn't find minecraft window. (Must be 1.7.10)");
        CheatManager::STOP_LISTENING();
    }

    DWORD PROCESS = Game::GET_PROCESS(H_WINDOW);

    if (PROCESS == NULL)
    {
        return Errors::THROW("Couldn't obtain process.");
        CheatManager::STOP_LISTENING();
    }

    HANDLE HANDLE = OpenProcess(PROCESS_ALL_ACCESS, FALSE, PROCESS);

    std::cout << "Minecraft Memory Hack Tester has successfully loaded.\n" << std::endl;

    while (CheatManager::IS_LISTENING())
    {
        if (GetAsyncKeyState('Q'))
        {
            CheatManager::RUN("FEED", HANDLE);
            std::cout << "CHEAT->FEED RAN SUCCESSFULLY." << std::endl;
        }
    }

    system("pause");
    return 0;
}
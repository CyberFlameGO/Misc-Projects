/**
 * This completely defeats the purpose of it being a surprise but I don't care
 * OPEN THIS !!!!
 */

#include <stdio.h>
#include <Windows.h>
#include <stdbool.h>
int main()
{
    system("title Demeng");

    for (int i = 0; i < 3; i++)
        printf("u r bad\n");

    int COLORS[] = { 1,2,3,4,5,6,7,8,9 };

    while (true)
    {
        for (int i = 0; i < 9; i++)
        {
            char COLOR = (char) COLORS[i];
            char COMMAND[9];

            sprintf(COMMAND, "color 0%d", COLOR);

            system(COMMAND);
            Sleep(100);
        }
    }

    system("pause");
    return 0;
}
#include <stdio.h>
#include <Windows.h>
#include <stdbool.h>

int main()
{
    system("title For You");

    printf("Everything is going to turn out alright :)\n");
    printf("Everything is going to turn out alright :)\n");
    printf("Everything is going to turn out alright :)\n\n");

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
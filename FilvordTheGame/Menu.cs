using System;
using System.Collections.Generic;
using System.Text;

namespace FilvordTheGame
{
    class Menu
    {
        public static void Print(int MenuSelect)
        {
            if (MenuSelect == 0)
                Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tNew Game\n");
            Console.ResetColor();

            if (MenuSelect == 1)
                Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tContinue \n");
            Console.ResetColor();

            if (MenuSelect == 2)
                Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tRanking\n");
            Console.ResetColor();

            if (MenuSelect == 3)
                Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\tExit\n");
            Console.ResetColor();
        }

        public static int GetSelectMenu(ConsoleKeyInfo key, int i)
        {
            if ((key.Key == ConsoleKey.W || key.Key == ConsoleKey.UpArrow) && (i != 0))
                return i - 1;
            else if ((key.Key == ConsoleKey.S || key.Key == ConsoleKey.DownArrow) && (i != 3))
                return i + 1;
            else
                return i;
        }
    }
}

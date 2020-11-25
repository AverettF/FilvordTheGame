using System;

namespace FilvordTheGame
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo key;
            int i = 0;
            do
            {
                Menu.Print(i);

                key = Console.ReadKey();
                i = Menu.GetSelectMenu(key, i);
                Console.Clear();

                if (key.Key == ConsoleKey.Enter)
                    SelectMenu(i);

            } while (!(key.Key == ConsoleKey.Enter && i == 3));

        }

        static void SelectMenu(int i)
        {
            switch (i)
            {
                case (0):
                    NewGame();
                    Console.ReadKey();
                    break;
                case (1):
                    Console.WriteLine("Здесь будет:Продолжить");
                    Console.ReadKey();
                    break;
                case (2):
                    Console.WriteLine("Здесь будет:таблица рекордов");
                    Console.ReadKey();
                    break;
                case (3):
                    Console.WriteLine("пока-пока");
                    Console.ReadKey();
                    break;
            }
        }

        static void NewGame()
        {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
        }

    }
}

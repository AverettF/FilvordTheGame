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

                //if (key.Key == ConsoleKey.Enter)
                //    //SelectMenu(i);

            } while (!(key.Key == ConsoleKey.Enter && i == 3));

        }

       

    }
}

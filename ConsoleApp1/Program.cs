using System;
using System.Security.Cryptography;

class Program
{
    static void Main()
    {
        game();
        Console.ReadLine();
    }

    static void game()
    {
        List<string> potentialReqruits = new List<string> { "1, 2, 3, 4, 5, 6, 7, 8, 9, 10" };
        List<string> aquiredReqruits = new List<string>();

        while (aquiredReqruits.Count < 3)
        {
            for (int i = 0; i < potentialReqruits.Count; i++)
            {
                Console.WriteLine(potentialReqruits[i]);
            }

            ConsoleKeyInfo keyInfo = Console.ReadKey(true);
            if (keyInfo.Key >= ConsoleKey.D1 && keyInfo.Key <= ConsoleKey.D9)
            {
                int whichKey = (int)keyInfo.Key - (int)ConsoleKey.D1;
                Console.WriteLine($"{whichKey}");
                Console.WriteLine($"you would have bought {potentialReqruits[whichKey]}");
                // aquiredReqruits.Add(potentialReqruits[whichKey]);
                
            }
        }
    }
}

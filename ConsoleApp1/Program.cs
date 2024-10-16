using System;
using System.Security.Cryptography;

Console.WriteLine("Hello welcome to yet another banger of a game");
Console.WriteLine("Today you will reqruits different people to help you in battle");
Console.WriteLine("Press enter to start");
game();

static void game()
{
    List<string> potentialReqruits = new List<string> { "Meaty michael", "frenchman", "royale George", "Dr. Rouge shooter", "september", "Nale", "Trues", "Zypheron", "Robert H. Smith" };
    List<string> aquiredReqruits = new List<string>();

    while (aquiredReqruits.Count < 3)
    {
        for (int i = 0; i < potentialReqruits.Count; i++)
        {
            Console.WriteLine($"{i + 1} - " + potentialReqruits[i]);
        }

        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        if (keyInfo.Key >= ConsoleKey.D1 && keyInfo.Key <= ConsoleKey.D9)
        {
            int whichKey = (int)keyInfo.Key - (int)ConsoleKey.D1;

            if (whichKey < potentialReqruits.Count)
            {
                Console.WriteLine($"{whichKey}");
                aquiredReqruits.Add(potentialReqruits[whichKey]);
                potentialReqruits.Remove(potentialReqruits[whichKey]);
                Console.Clear();
                Console.WriteLine($"you reqruited {aquiredReqruits[^1]}!");

                if (aquiredReqruits.Count < 3)
                {
                    Console.WriteLine($"you can reqruit {3 - aquiredReqruits.Count} people more");
                    Console.WriteLine("\n ");
                }
                else
                {
                    Console.WriteLine("You can not reqruit anyone else.");
                    Console.WriteLine("\nyou have reqruited the following people:");

                    for (int i = 0; i < aquiredReqruits.Count; i++)
                    {
                        Console.WriteLine(aquiredReqruits[i]);
                    }

                    Console.WriteLine("Press R to restart the game and backspace if you wanna remove a reqruit.");
                    keyInfo = Console.ReadKey(true);

                    if (keyInfo.Key == ConsoleKey.R)
                    {
                        Console.Clear();
                        game();
                    }
                    else if (keyInfo.Key == ConsoleKey.Backspace)
                    {
                        Console.Clear();
                        Console.WriteLine("Which of your reqruits do you wanna remove from your team?");

                        for (int i = 0; i < aquiredReqruits.Count; i++)
                        {
                            Console.WriteLine($"{i + 1} - " + aquiredReqruits[i]);
                        }

                        keyInfo = Console.ReadKey(true);
                        whichKey = (int)keyInfo.Key - (int)ConsoleKey.D1;
                        if (keyInfo.Key >= ConsoleKey.D1 && keyInfo.Key <= ConsoleKey.D9)
                        {
                            string removedRecruit = aquiredReqruits[whichKey];
                            aquiredReqruits.RemoveAt(whichKey);
                            potentialReqruits.Add(removedRecruit);
                            Console.WriteLine($"You removed {removedRecruit}");
                        }
                        else
                        {
                            Console.WriteLine("\nPlease choose on of the reqruits");
                        }
                    }
                }
            }
            else
            {
                Console.WriteLine("\nYou cannot choose that reqruit, try again");
            }
        }
        else
        {
            Console.WriteLine("\nPlease choose one of the reqruits");
        }

    }
}


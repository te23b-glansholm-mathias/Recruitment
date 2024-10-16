Console.WriteLine("Hello welcome to yet another banger of a game");
Console.WriteLine("Today you will reqruits different people to help you in battle");
Console.WriteLine("Press enter to start");
Console.ReadLine();
Console.Clear();
game();

static void game() //everything is a function so I can call it
{
    List<string> potentialReqruits = new List<string> { "Meaty michael", "frenchman", "royale George", "Dr. Rouge shooter", "september", "Nale", "Trues", "Zypheron", "Robert H. Smith" };
    List<string> aquiredReqruits = new List<string>();

    while (aquiredReqruits.Count < 3)
    {
        for (int i = 0; i < potentialReqruits.Count; i++) //writes out people you can reqruit 
        {
            Console.WriteLine($"{i + 1} - " + potentialReqruits[i]);
        }

        ConsoleKeyInfo keyInfo = Console.ReadKey(true);
        if (keyInfo.Key >= ConsoleKey.D1 && keyInfo.Key <= ConsoleKey.D9) //check so your input works
        {
            int whichKey = (int)keyInfo.Key - (int)ConsoleKey.D1; //Fixes your input to work with the list

            if (whichKey < potentialReqruits.Count)
            {
                Console.WriteLine($"{whichKey}");
                aquiredReqruits.Add(potentialReqruits[whichKey]);
                potentialReqruits.Remove(potentialReqruits[whichKey]);
                Console.Clear();
                Console.WriteLine($"you reqruited {aquiredReqruits[^1]}!"); //Writes the last index in the list

                if (aquiredReqruits.Count < 3)
                {
                    Console.WriteLine($"you can reqruit {3 - aquiredReqruits.Count} people more");
                    Console.WriteLine("\n ");
                }
                else
                {
                    Console.WriteLine("You can not reqruit anyone else.");
                    Console.WriteLine("\nyou have reqruited the following people:");

                    for (int i = 0; i < aquiredReqruits.Count; i++) //writes out the people you have reqruited
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


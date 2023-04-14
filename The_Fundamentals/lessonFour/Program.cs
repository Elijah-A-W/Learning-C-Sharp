// See https://aka.ms/new-console-template for more information



using System;


class guessGame
{
    static void Main(string[] args)
    {

        string guessWord  = "owaye";
        string wordChoice = "";
        int guesslimit    = 3;
        int guessCount    = 0;
        bool outofGuesses = false;



        while (wordChoice != guessWord && !outofGuesses)
        {
            if (guessCount < guesslimit)
            {
                Console.Write("We are guessing the right Luganda word here: ");
                wordChoice = Console.ReadLine();
                guessCount++;
            }
            else
            {
                outofGuesses = true;
            }
        }

        if (outofGuesses)
        {
            Console.WriteLine("Sorry you lose");
        }
        else
        {
            Console.WriteLine("Webale okugesinga");
        }

        



        Console.ReadLine();
    }

    
}

using System;

class Program
{
    static void Main(string[] args)
    {

        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);

        int guess = -1;
        int guessCount = 0;
        bool play = true;
        do
        {
            while (guess != magicNumber)
            {
                Console.Write("What is your guess? ");
                guess = int.Parse(Console.ReadLine());
                guessCount = guessCount +1;

                if (magicNumber > guess)
                {
                    Console.WriteLine("Higher");
                }
                else if (magicNumber < guess)
                {
                    Console.WriteLine("Lower");
                }
                else
                {
                    Console.WriteLine("You guessed it!");
                }
                Console.WriteLine($"it took you {guessCount} guess to get it right. ");
                Console.Write("do you want to keep playing?(yes/no) ");
                string responce = Console.ReadLine();

                if (responce == "no")
                {
                    play = false;
                }
                else
                {
                    play = true;
                }
            }
        } while (play);
    }
        
}
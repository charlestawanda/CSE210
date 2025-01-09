using System;

class Program
{
    static void Main(string[] args)
    {
            DisplayWelcomeMessage();

        string userName = PromptUserName();
        int userNumber = PromptUserNumber();

        int squaredNumber = SquareNumber(userNumber);

        DisplayResult(userName, userNumber, squaredNumber);
    }

    static void DisplayWelcomeMessage()
    {
        Console.WriteLine("Welcome to the program! hope that your are having a great day, we wish to make a change if you were not feelong to good. to those that are feeling well great ready for a better challenge. to enjoy the game, the instructions are simple just follow them and sit tight and enjoy.");
    }

    static string PromptUserName()
    {
        Console.Write("enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int number = int.Parse(Console.ReadLine());

        return number;
    }

    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }

    static void DisplayResult(string name,int number, int square)
    {
        Console.WriteLine($"we say thank you {name} for playng the game. it's great to know you, since the number of your choice is: {number}, which made the square of {square}");
    
    }
}
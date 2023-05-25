using System;

public class Program
{
    public static void Main()
    {
        Console.WriteLine("Hello, and welcome to my coin flip challenge. What is your name challenger?");
        string name = Console.ReadLine();

        Console.WriteLine("Welcome " + name + ". Would you like to proceed with the challenge? (yes or no)");
        string choice = Console.ReadLine();

        if (choice == "yes")
        {
            int score = 0;
            for(int i = 0; i < 5; i++)
            {
                Random random = new Random();
                int flip = random.Next(0, 2);
                Console.WriteLine("Heads or Tails? (plesase capitalize)");
                string call = Console.ReadLine();

                if(call == "Heads" && flip == 1 || call == "Tails" && flip == 0)
                {
                    Console.WriteLine("Correct!");
                    score++;
                }else
                {
                    Console.WriteLine("Wrong!");
                }
            }
            Console.WriteLine("Thank you " + name + ". You got a score of " + score + "!");
        }else if (choice == "no")
        {
            Console.WriteLine( "You "+ name + ", are a coward, begone with you!");
        }
    }
}
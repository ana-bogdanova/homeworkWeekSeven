using System;

class Program
{
    static Random random = new Random();
    static void Main()
    {
        if (ShouldPlay())
        {
            LuckyNumberGame();
        }
    }
 static bool ShouldPlay()
{
    while (true)
    {
        try
        {
            Console.WriteLine("Would you like to see if you're lucky today? Enter 1 for Yes and 0 for No");
            int response = int.Parse(Console.ReadLine());
           
            if (response == 1)
              return true;
            
            else if (response == 0)
              return false;
            
            else
                Console.WriteLine("Invalid choice. Please enter 1 for Yes or 0 for No.");
        
        }
        catch
        {
             Console.WriteLine("Enter 1 for yes and 0 for No");
        }
   }

}

 static void LuckyNumberGame()
 {
    int enteredNumber;
    while (true)
    {
        try
        {
            Console.WriteLine("Think of the number that this program has chosen. Guess and enter the number from 1 to 10");
            string numberGuessed = Console.ReadLine();
            enteredNumber = int.Parse(numberGuessed);

            if (enteredNumber < 1 || enteredNumber > 10)
            {
                Console.WriteLine("Please enter a number between 1 and 10.");
                continue;
            }
            break;
        }
        
        catch
        {
            Console.WriteLine("Please enter a valid number");
        }
    }

    int number = random.Next(1, 11);

    if (number == enteredNumber)
    {
        Console.WriteLine($"You're lucky today! You guessed {number} right!");
    }
    else
    {
        Console.WriteLine($"Sorry, the number was {number}. You guessed {enteredNumber}. Try again!");
    }
 }
}

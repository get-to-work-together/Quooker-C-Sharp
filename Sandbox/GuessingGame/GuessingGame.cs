public class GuessingGame
{
    static public void Main()
    {
        const int Lower = 1;
        const int Upper = 100;

        int secretNumber = new Random().Next(Lower, Upper);
        int numberOfGuesses = 0;

        Console.WriteLine($"Guess a number between {Lower} and {Upper}.");

        for (; ; )
        {
            Console.Write("What is your (next) guess? : ");

            string? userInput = Console.ReadLine();
            numberOfGuesses ++;

            bool success = int.TryParse(userInput, out int guess);
            if (success)
            {
                if (guess < Lower)
                {
                    Console.WriteLine($"{guess} is lower than {Lower}");
                }
                else if (guess > Upper)
                {
                    Console.WriteLine($"{guess} is higher than {Upper}");
                }
                else if (guess < secretNumber)
                {
                    Console.WriteLine("higher ...");
                }
                else if (guess > secretNumber)
                {
                    Console.WriteLine("lower ...");
                }
                else
                {
                    Console.WriteLine($"YEAH! The number was {secretNumber}. You guessed it in {numberOfGuesses} guesses!");
                    break;
                }
            }
            else
            {
                Console.WriteLine($"\"{userInput}\" is not a number");
            }
        }
    }
}

using System;


namespace NumberGuesser
{
    class Program
    {
        static void Main(string[] args)
        {
          
            GetAppInfo();
            Greeting();
            

            while (true)
            {
                //Initialize Random object
                Random rnd = new Random();

                //get random number between 1 and 10
                int correctNumber = rnd.Next(1, 10);

                //Storage for user guess
                int guess = 0;
                Console.WriteLine("Guess a number between 1 and 10.");

                //While the guess is not correct
                while (guess != correctNumber)
                {
                    //Gets user input
                    string userAnswer = Console.ReadLine()!;

                    //Make sure the input is an number
                    if (!int.TryParse(userAnswer, out guess))
                    {
                        DisplayMessageInColor(ConsoleColor.Red, "Please enter an actual number!");
                        continue;
                    }

                    //Cast the user input to int
                    guess = int.Parse(userAnswer);

                    //Make sure the guess is the correct number
                    if (guess != correctNumber)
                    {
                        //Display "wrong message" in red
                        DisplayMessageInColor(ConsoleColor.Red, "Wrong number please try again!");
                    }
                }

                //Display "correct message in yellow"
                DisplayMessageInColor(ConsoleColor.Yellow, "You are correct!");

                //Ask to play again
                Console.WriteLine("Play again? [Y or N]");

                string playAgain= Console.ReadLine()!.ToUpper();

                if (playAgain == "Y")
                {
                    continue;
                }
                else if(playAgain == "N")
                {
                    return;
                }
                else
                {
                    return;
                }
                

            }

        }

        /// <summary>
        /// Displays Informations about the App
        /// </summary>
        static void GetAppInfo()
        {
            //App info
            string appName = "Number Guesser";
            string appVersion = "1.0.0";
            string appAuthor = "Armin Midzan";

            //Display header 
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(" ---------------------------------------------");
            Console.WriteLine($"|{appName}: Version {appVersion} by {appAuthor}|");
            Console.WriteLine(" ---------------------------------------------");
            Console.ResetColor();
        }

        /// <summary>
        /// Displays a Greeting
        /// </summary>
        static void Greeting()
        {
            Console.WriteLine("Greetings, What is your name?");
            string input = Console.ReadLine()!;
            Console.WriteLine($"Hello {input}, let's play a game!");
        }

        /// <summary>
        /// Prints out a message in color
        /// </summary>
        /// <param name="color">The color in which the message will be printed out</param>
        /// <param name="message">Message to be printed to the console</param>
        static void DisplayMessageInColor(ConsoleColor color,string message)
        {
            Console.ForegroundColor = color;
            Console.WriteLine($"{message}");
            Console.ResetColor();

        }

    }
}

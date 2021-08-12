using System;

namespace Guess_the_Num
{
    class Program
    {
        static void Main(string[] args)
        {
            Start();


            Console.Read();
        }

        
        public static void Start()
        {
            Console.WriteLine("Welcome to the Guess the Num game!");
            Console.WriteLine("Now, please enter the number where the game starts, and the number, where the games ends!");
            Console.Write("Enter the starting number: ");
            string startNumS = Console.ReadLine();
            int startNum;
            bool isParseable = int.TryParse(startNumS, out startNum);
            if (isParseable)
            {
                
                Console.WriteLine("Nice, the selected number is {0}!", startNum);
                Console.Write("Now, define the second number: ");
                int endNum;
                string endNumS = Console.ReadLine();
                bool isParseable1 = int.TryParse(endNumS, out endNum);
                if(isParseable1){
                    Console.WriteLine("The range is set from {0} to {1}!", startNum, endNum);
                    Console.WriteLine("Generated Random Number!");
                    Random numberGen = new Random();
                    int RandNum =0;
                    int guess = 0;
                    int attemps = 0;
                    RandNum = numberGen.Next(startNum, endNum);
                    Console.WriteLine("You can guess now!");
                    while(guess != RandNum)
                    {
                        
                        Console.Write("Guess the number: ");                       
                        guess = Convert.ToInt32(Console.ReadLine());
                        attemps++;
                    }
                    Console.WriteLine("It took you {0} attempts to guess {1}!", attemps, guess);
                    Console.WriteLine("Do you want to continue? If so type c.");
                    string cont = Console.ReadLine();
                    if(cont == "c")
                    {
                        Start();
                    }
                    
                    



                }
                else
                {
                    Console.WriteLine("This doesn't work, restart the program!");
                    
                }

            }
            else
            {
                Console.WriteLine("This doesn't work, restart the program!");
                Console.WriteLine("Just Simon");
            }
        }

    }
}

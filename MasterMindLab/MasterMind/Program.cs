using System;
using System.Collections.Generic;
using MasterMindLibrary;


namespace MasterMind
{
    class Program
    {
        static List<Peg> pegList = new List<Peg>()
        {
            new Peg(ConsoleColor.White, ConsoleColor.Red),
            new Peg(ConsoleColor.White, ConsoleColor.Blue),
            new Peg(ConsoleColor.Black, ConsoleColor.Green),
            new Peg(ConsoleColor.Black, ConsoleColor.Yellow),
            new Peg(ConsoleColor.Black, ConsoleColor.Cyan),
            new Peg(ConsoleColor.White, ConsoleColor.Magenta),
            new Peg(ConsoleColor.White, ConsoleColor.DarkGray),
            new Peg(ConsoleColor.White, ConsoleColor.DarkRed)
        };

        static void Main(string[] args)
        {
            List<Attempt> allAttempts = new List<Attempt>();

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("Welcome to Mastermind!");
            Console.ResetColor();

            //ask for difficulty
            Console.WriteLine("Choose Difficutly");
            int difficulty = MMLib.GetConsoleMenu(new List<string> { "Easy: 4 Colors", "Medium: 6 Colors", "Hard: 8 Colors" });

            //ask for maxTurns of turns to guess it
            int maxTurns = MMLib.GetConsoleInt("How many attempts? (1-50)", 1, 50);

            //store the maxPegs based on difficulty
            int maxPegs = (difficulty + 1) * 2;

            //Generate an answer
             List<int> answer = MMLib.GenerateAnswer(maxPegs);

            //show cheat? 
            MMLib.Cheat(answer, pegList);

            bool gameWon = false;

            //loop while !gameWon && maxTurns != 0
            //  get user attempt
            //  Check the attempt for a correct guess
            //  add the attempt to the attempt list
            //  determin if the game has been won or not
            //  reduce the maxTurns

            while (!gameWon && maxTurns != 0)
            {
                //get user attempt
                Attempt attempt = GetAttemptFromUser(maxPegs, allAttempts, maxTurns);
                CheckAttempt(attempt, answer);
                if (attempt.CorrectAnswerCount == maxPegs)
                {
                    gameWon = true;
                }
                allAttempts.Add(attempt);
                maxTurns--;
                



            }


            //If won, display Game Won!
            //If lost, show game loss
            //show the correct answer

            if (gameWon)
            {
                Console.WriteLine("You Won!");
            }
            else
            {
                Console.WriteLine("You Lost!");
            }

            Console.WriteLine("The correct answer was:");
            MMLib.ShowAnswer(answer, pegList, "O");
        }
        
        static Attempt GetAttemptFromUser(int maxPegs, List<Attempt> allAttempts, int maxTurns)
        {
            //Create a new Attempt
            Attempt attempt = new Attempt();
            //Get color options based on maxPegs
            List<string> colorOptions = MMLib.GetColorOptions(maxPegs, pegList);
            Console.WriteLine("coloroptions " + colorOptions );
            //Loop of # of pegs they need to choose
            //      clear console
            //      Display # of attempts left
            //      Show all previous attempts
            //      Show pegs they have chosen already in this attempt
            //      Ask them to pick a peg color from a menu of options
            //      Add the chosen peg to the Attempt.AttemptList
            //Return the attempt when done
            for (int pegChoice = 0; pegChoice < maxPegs; pegChoice++)
            {
                Console.Clear();
                Console.WriteLine("Attempts Left: {0}", maxTurns);
                MMLib.ShowAttempts(allAttempts, pegList, "O");
                Console.WriteLine("Attempt so far:");
                MMLib.ShowAttempts(new List<Attempt> { attempt }, pegList, "O");
                Console.WriteLine("Choose a color:");
                int colorChoice = MMLib.GetConsoleMenu(colorOptions) - 1;
                attempt.AttemptList.Add(colorChoice);
            }

            

            return attempt;
        }


        static void CheckAttempt(Attempt attempt, List<int> answer)
        {
            //Check the attempt.AttemptList to see if they got a match to the answer
            //If a peg is correct, increment the attempt.CorrectAnswerCount
            for (int i = 0; i < attempt.AttemptList.Count; i++)
            {
                if (attempt.AttemptList[i] == answer[i])
                {
                    attempt.CorrectAnswerCount++;
                }
            }

        }
    }
}

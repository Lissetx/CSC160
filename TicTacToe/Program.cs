namespace TicTacToe
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[,] board = new char[3, 3]; //game board, default value for char is space

            string[] playerNames = { "Player 1", "Player 2" };

            char[] playerSymbols = { 'X', 'O' };

            bool gameOver = false; //Game condition for exit

            int turn = 0; //Whose current turn 

            int totalTurn = 0; //Check for cat's game when 9 

            //Enter player name
            Console.Write("Enter player1 name: ");
            playerNames[0] = Console.ReadLine();
            Console.Write("Enter player2 name: ");
            playerNames[1] = Console.ReadLine();

            

            do
            {
               
                //Display board
                Console.WriteLine();
                Console.WriteLine($"{playerNames[turn]}'s Turn");
                DisplayBoard(board);

                bool validInput = false;
                int chosenRow;
                int chosenCol;

                

                //Get row and col
                do
                {
                    Console.Write("Enter row: ");
                    bool validRow = int.TryParse(Console.ReadLine(), out chosenRow);

                    Console.Write("Enter col: ");
                    bool validCol = int.TryParse(Console.ReadLine(), out chosenCol);

                    //make selection match array index
                    chosenRow--;
                    chosenCol--;

                   
                    

                    if (validRow && validCol)
                    {
                        
                        if (chosenRow >= 0 && chosenRow < board.GetLength(0) && chosenCol >= 0 && chosenCol < board.GetLength(1))
                        {
                            Console.WriteLine();
                            if (board[chosenRow, chosenCol] != 'X' && board[chosenRow, chosenCol] != 'O')
                            {
                                validInput = true;
                            }
                            else
                            {
                                Console.WriteLine("That space is already taken. Please choose another.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("That is not a valid space. Please choose another.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("That is not a valid space. Please choose another.");
                    }

                } while (!validInput);

                //Place symbol
                board[chosenRow, chosenCol] = playerSymbols[turn];

                //Check for win
                if (CheckForWin(board, playerSymbols[turn]))
                {
                    DisplayBoard(board);
                    Console.WriteLine($"{playerNames[turn]} wins!");
                    gameOver = true;
                }
                else
                {
                    //Check for cat's game
                    totalTurn++;
                    if (totalTurn == 9)
                    {
                        Console.WriteLine("Cat's game!");
                        DisplayBoard(board);
                        gameOver = true;
                    }
                    else
                    {
                        //Switch turns
                        turn = (turn + 1) % 2;
                    }
                }

                //break will get you out of loop before condition is met

            } while (!gameOver);
        }
        
        public static void DisplayBoard(char[,] board)
        {
            for (int row = 0; row < board.GetLength(0); row++)
            {
                //then looop through collum, display X or O and pipe symbol |
                for (int col = 0; col < board.GetLength(1); col++)
                {

                  
                 
                        if (board[row, col] == 'X' || board[row, col] == 'O')
                        {
                        if (col < board.GetLength(1) - 1)
                        {
                            Console.Write($"{board[row, col]} | ");
                        }
                        else
                        {
                            Console.Write($"{board[row, col]} ");
                        }
                        }
                    else if (col < board.GetLength(1) - 1)
                    {
                            Console.Write("  | ");
                        }

                    
                }
                //display dash symbol - after each row
                if (row < board.GetLength(0) - 1)
                {
                    Console.WriteLine();
                    Console.WriteLine("---------");
                }
                Console.WriteLine();
            }
        }
        public static bool CheckForWin(char[,] board, char symbol)
        {
            //Check rows
            for (int row = 0; row < board.GetLength(0); row++)
            {
                if (board[row, 0] == symbol && board[row, 1] == symbol && board[row, 2] == symbol)
                {
                    return true;
                }
            }

            //Check columns
            for (int col = 0; col < board.GetLength(1); col++)
            {
                if (board[0, col] == symbol && board[1, col] == symbol && board[2, col] == symbol)
                {
                    return true;
                }
            }

            //Check diagonals
            if (board[0, 0] == symbol && board[1, 1] == symbol && board[2, 2] == symbol)
            {
                return true;
            }
            if (board[0, 2] == symbol && board[1, 1] == symbol && board[2, 0] == symbol)
            {
                return true;
            }

            return false;
        }


    }
}
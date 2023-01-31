using GameHub.Menu;

namespace GameHub.Model
{
    public class Board
    {
        
        public static void PrintTictacToeBoard(char[] spaces)
        {
            Console.WriteLine($"   {spaces[0]} | {spaces[1]} | {spaces[2]}   ");
            Console.WriteLine("---------------");
            Console.WriteLine($"   {spaces[3]} | {spaces[4]} | {spaces[5]}   ");
            Console.WriteLine("---------------");
            Console.WriteLine($"   {spaces[6]} | {spaces[7]} | {spaces[8]}   ");

        }

        public static int ChangePlayer(int playerNumber)
        {

            if (playerNumber.Equals(1))
            {
                return 2;
            }
            return 1;

        }

        public static int ChangePlayerName(string playerNumber)
        {

            if (playerNumber.Equals(1))
            {
                return 2;
            }
            return 1;

        }



        public static char GetPlayerSymbol(int player)
        {

            if (player % 2 == 0)
            {

                return 'O';
            }
            return 'X';
        }

        public static void RunTictacToe(char[] spaceOptions, int currentPlayer)
        {

            Console.Write("\nEscolha um número de 1 a 9: ");
            string userOption = Console.ReadLine();

            bool invalidMove = true;

            do
            {
                if (!string.IsNullOrEmpty(userOption) &&
                    (userOption.Equals("1") ||
                    userOption.Equals("2") ||
                    userOption.Equals("3") ||
                    userOption.Equals("4") ||
                    userOption.Equals("5") ||
                    userOption.Equals("6") ||
                    userOption.Equals("7") ||
                    userOption.Equals("8") ||
                    userOption.Equals("9")))
                {

                    Console.Clear();

                    int.TryParse(userOption, out var gamePlacementSymbol);

                    char currentSymbol = spaceOptions[gamePlacementSymbol - 1];

                    if (currentSymbol.Equals('X') || currentSymbol.Equals('O'))
                    {
                        Menu.Menu.TicTacToeHeader(currentPlayer);
                        Board.PrintTictacToeBoard(spaceOptions);
                        Console.WriteLine("Espaço já preenchido, escolha outro.");
                        Console.Write("\nEscolha um número de 1 a 9: ");
                        
                        userOption = Console.ReadLine();
                    }
                    else
                    {
                        spaceOptions[gamePlacementSymbol - 1] = GetPlayerSymbol(currentPlayer);

                        invalidMove = false;
                    }
                }
                else
                {
                    Console.WriteLine("Valor inválido, tente novamente.");
                    Console.Write("\nEscolha um número de 1 a 9: ");
                    userOption = Console.ReadLine();

                }

            } while (invalidMove);

        }

        public static int CheckWinner(char[] gameSymbols)
        {

            if (IsGameDraw(gameSymbols))
            {
                return 2;
            }

            if (IsGameWinner(gameSymbols))
            {

                return 1;
            }

            return 0;
        }

        public static bool IsGameDraw(char[] gameSymbols)
        {

            return gameSymbols[0] != '1' &&
                   gameSymbols[1] != '2' &&
                   gameSymbols[2] != '3' &&
                   gameSymbols[3] != '4' &&
                   gameSymbols[4] != '5' &&
                   gameSymbols[5] != '6' &&
                   gameSymbols[6] != '7' &&
                   gameSymbols[7] != '8' &&
                   gameSymbols[8] != '9';

        }

        public static bool IsGameWinner(char[] gameSymbols)
        {

            if (IsGameSymbolsTheSame(gameSymbols, 0, 1, 2))
            {
                return true;
            }
            if (IsGameSymbolsTheSame(gameSymbols, 3, 4, 5))
            {
                return true;
            }
            if (IsGameSymbolsTheSame(gameSymbols, 6, 7, 8))
            {
                return true;
            }
            if (IsGameSymbolsTheSame(gameSymbols, 0, 3, 6))
            {
                return true;
            }
            if (IsGameSymbolsTheSame(gameSymbols, 1, 4, 7))
            {
                return true;
            }
            if (IsGameSymbolsTheSame(gameSymbols, 2, 5, 8))
            {
                return true;
            }
            if (IsGameSymbolsTheSame(gameSymbols, 0, 4, 8))
            {
                return true;
            }
            if (IsGameSymbolsTheSame(gameSymbols, 2, 4, 6))
            {
                return true;
            }

            return false;
        }

        public static bool IsGameSymbolsTheSame(char[] testGameSymbols, int pos1, int pos2, int pos3)
        {

            return testGameSymbols[pos1].Equals(testGameSymbols[pos2]) && testGameSymbols[pos2].Equals(testGameSymbols[pos3]);
        }

        //public static void ChangePlayerName(int playerNumber, string player1, int player2)
        //{
        //    if (playerNumber.Equals(1))
        //    {
        //        return player2;
        //    }
        //    return player1;

        //}

        //public static void RequestLogin()
        //{

        //}
    }
}

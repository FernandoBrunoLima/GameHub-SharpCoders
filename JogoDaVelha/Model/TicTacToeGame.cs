using GameHub.Model;
using GameHub.Menu;

namespace GameHub.Model
{
    public class TicTacToeGame
    {

        public static void GetGameTic()
        {
            int gameOn = 0;
            int currentPlayer = -1;
            char[] spaceOptions = { '1', '2', '3', '4', '5', '6', '7', '8', '9' };
            string currentPlayerName = string.Empty;

            Player player1 = new Player();
            Player player2 = new Player();

            do
            {
                Console.Clear();

                currentPlayer = Board.ChangePlayer(currentPlayer);
                // currentPlayerName = Board.ChangePlayerName(currentPlayerName);

                Menu.Menu.TicTacToeHeader(currentPlayer);
                Board.PrintTictacToeBoard(spaceOptions);

                Board.RunTictacToe(spaceOptions, currentPlayer);

                gameOn = Board.CheckWinner(spaceOptions);


            } while (gameOn.Equals(0));

            Console.Clear();
            Menu.Menu.TicTacToeHeader(currentPlayer);
            Board.PrintTictacToeBoard(spaceOptions);


            if (gameOn.Equals(1))
            {

                Console.WriteLine($"\nO jogador {currentPlayer} é o vencedor!");
            }

            if (gameOn.Equals(2))
            {

                Console.WriteLine($"\nEmpate!");
            }
        }
    }
}

        

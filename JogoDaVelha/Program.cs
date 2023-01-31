using GameHub.Model;
using GameHub.Menu;
using System;

namespace GameHub
{
    
    class Program
    {
        
        public static void Main(string[] args)
        {

            List<string> playerNames = new List<string>(); // { "Player1", "Player2" };
            List<string> passwords = new List<string>(); // { "password1", "password2" };
            List<int> allWins = new List<int>(); // { 10, 5 };
            List<int> allLosses = new List<int>(); // { 2, 8 };
            List<int> allDraws = new List<int>(); // { 1, 1 };

            //Player player1 = new Player(playerNames, passwords, allWins, allLosses, allDraws);
            //Player player2 = new Player(playerNames, passwords, allWins, allLosses, allDraws);

            int option = 0;

            do
            {
                Menu.Menu.HeaderGameHub();

                Menu.Menu.ShowMainMenu();
                option = int.Parse(Console.ReadLine());

                Console.Clear();
                Menu.Menu.HeaderGameHub();

                switch (option)
                {
                    case 0:
                        Console.WriteLine("Encerrando o programa...");
                        break;
                    case 1:
                        Player.InsertNewPlayer(playerNames, passwords);
                        //Console.Clear();
                        break;
                    case 2:
                        //Console.Clear();
                        Player.ListAllPlayers(playerNames, allWins, allLosses, allDraws);
                        //Console.Clear();
                        break;
                    case 3:
                        Player.RequestLogin(playerNames, passwords);
                        TicTacToeGame.GetGameTic();
                        break;
                    case 4:
                        Menu.Menu.BattleShipHeader(1);
                        break;
                    case 5:
                        Console.WriteLine("Ranking; em implantação...");
                        Console.Clear();
                        break;

                        
                }

                

            } while (option != 0);

           

        }




















    }

}


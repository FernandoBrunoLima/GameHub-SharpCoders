using System.Numerics;
using System.Text.Json;

namespace GameHub.Model
{
    public class Player
    {
        public string? Name { get; set; }
        public string? Password { get; set; }
        public int Wins { get; set; }
        public int Losses { get; set; }
        public int Draws { get; set; }

        public Player()
        {

        }
        public Player(string name, string password, int wins, int losses, int draws)
        {
            Name = name;
            Password = password;
            Wins = wins;
            Losses = losses;
            Draws = draws;
        }

        //public string Player1 { get; set; }
        //public string Player2 { get; set; }

        //public List<string> PlayerNames { get; set; }
        //public List<string> Passwords { get; set; }
        //public List<int> AllWins { get; set; }
        //public List<int> AllLosses { get; set; }
        //public List<int> AllDraws { get; set; }

        //public string Player1 { get; set; }
        //public string Player2 { get; set; }

        //public Player(string player1, string player2)
        //{
        //    Player1 = player1;
        //    Player2 = player2;
        //}
        //public Player(List<string> playerNames, List<string> passwords, List<int> allWins, List<int> allLosses, List<int> allDraws)
        //{
        //    PlayerNames = playerNames;
        //    Passwords = passwords;
        //    AllWins = allWins;
        //    AllLosses = allLosses;
        //    AllDraws = allDraws;
        //}


        public static void RequestLogin(List<string> PlayerNames, List<string> Passwords)
        {
            Console.WriteLine("Insira o nome do jogador: ");
            PlayerNames.Add(Console.ReadLine());
            Console.WriteLine("Insira a senha do jogador:");
            Passwords.Add(Console.ReadLine());
        }
       
        public static void InsertNewPlayer(List<string> PlayerNames, List<string> Passwords)
        {
            Console.WriteLine("Insira o nome do jogador: ");
            PlayerNames.Add(Console.ReadLine());
            Console.WriteLine("Insira a senha do jogador:");
            Passwords.Add(Console.ReadLine());
        }


        public static void ListAllPlayers(List<string> PlayerNames, List<int> AllWins, List<int> AllLosses, List<int> AllDraws)
        {
            for (int i = 0; i < PlayerNames.Count; i++)
            {
                Console.WriteLine($" Jogador(a): {PlayerNames[i]} | Vitórias: {AllWins[i]} | Perdas: {AllLosses[i]} | Empates: {AllDraws[i]}");
            }
        }

    }


}

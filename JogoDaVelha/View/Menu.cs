namespace GameHub.Menu
{
    public class Menu
    {
        public static void HeaderGameHub()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("----- GameHub SharpCoders -----");
            Console.WriteLine("-------------------------------\n");
        }
        public static void TicTacToeHeader(int PlayerNumber)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("        Jogo da Velha          ");
            Console.WriteLine("-------------------------------\n");

            Console.WriteLine("Jogador 1: X");
            Console.WriteLine("Jogador 2: 0\n");

            Console.WriteLine($"É a vez do jogador {PlayerNumber}\n");

        }

        public static void BattleShipHeader(int PlayerNumber)
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("        Batalha Naval          ");
            Console.WriteLine("-------------------------------\n");

            Console.WriteLine("Em desenvolvimento...");


            //Console.WriteLine($"É a vez do jogador {PlayerNumber}\n");

        }
        public static void ShowMainMenu()
        {

            Console.WriteLine("1 - Inserir novo jogador");
            Console.WriteLine("2 - Listar todos os jogadores");
            Console.WriteLine("3 - Jogo da Velha");
            Console.WriteLine("4 - Batalha Naval");
            Console.WriteLine("5 - Mostrar ranking");
            Console.WriteLine("0 - Sair do programa\n");

            Console.Write("Digite a opção desejada: ");

        }

        public static void ShowGamesMenu()
        {

            Console.WriteLine("1 - Jogo da Velha");
            Console.WriteLine("2 - Batalha Naval");
            Console.WriteLine("0 - Sair do programa\n");

            Console.Write("Digite a opção desejada: ");

        }
    }
}

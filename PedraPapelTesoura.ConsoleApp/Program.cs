class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            ExibirTitulo();

            int escolhaJogador = Jogador.ObterEscolha();

            int escolhaComputador = Computador.ObterEscolha();

            Jogo.CompararEscolhas(escolhaJogador, escolhaComputador);

            if (!JogadorDesejaContinuar())
            {
                break;
            }


        }
    }

    static void ExibirTitulo()
    {
        Console.Clear();

        Console.BackgroundColor = ConsoleColor.Gray;

        Console.WriteLine("------------------------------------");
        Console.ForegroundColor = ConsoleColor.DarkGreen;
        Console.Write("Pedra,");
        Console.ForegroundColor = ConsoleColor.DarkRed;
        Console.Write(" papel");
        Console.ForegroundColor = ConsoleColor.White;
        Console.Write(" e");
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.Write(" tesoura");
        Console.ForegroundColor = ConsoleColor.White;
        Console.WriteLine("\n------------------------------------");

        Console.BackgroundColor = ConsoleColor.Black;

    }

    static bool JogadorDesejaContinuar()
    {
        Console.WriteLine("------------------------------------");
        Console.Write("Deseja continuar? (S/N): ");

        if (Console.ReadLine()?.ToUpper() != "S")
            return false;

        return true;
    }
}


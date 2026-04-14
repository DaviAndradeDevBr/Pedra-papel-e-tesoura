class Jogo
{
    public static void CompararEscolhas(int escolhaJogador, int escolhaComputador)
    {
        const int ESCOLHA_PEDRA = 1;
        const int ESCOLHA_PAPEL = 2;
        const int ESCOLHA_TESOURA = 3;

        if (escolhaJogador == escolhaComputador)
        {
            if (escolhaJogador == ESCOLHA_PEDRA)
            {
                Console.WriteLine("------------------------------------");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Pedra vs Pedra");
                Console.ResetColor();
            }
            else if (escolhaJogador == ESCOLHA_PAPEL)
            {
                Console.WriteLine("------------------------------------");
                 Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Papel vs Papel");
                Console.ResetColor();
            }
            else if (escolhaJogador == ESCOLHA_TESOURA)
            {
                Console.WriteLine("------------------------------------");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Tesoura vs Tesoura");
                Console.ResetColor();
            }

            Console.WriteLine("------------------------------------");
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Empate!");
            Console.ResetColor();
            Console.WriteLine("------------------------------------");
        }
        else if (escolhaJogador == ESCOLHA_PEDRA)
        {
            Console.WriteLine("------------------------------------");
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Pedra vs ");
            Console.ResetColor();

            if (escolhaComputador == ESCOLHA_PAPEL)
            {
                Console.WriteLine("Papel");
                Console.WriteLine("------------------------------------");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("O computador venceu.");
                Console.ResetColor();
            }
            else if (escolhaComputador == ESCOLHA_TESOURA)
            {
                Console.WriteLine("Tesoura");
                Console.WriteLine("------------------------------------");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Você venceu.");
                Console.ResetColor();
            }
        }
        else if (escolhaJogador == ESCOLHA_PAPEL)
        {
            Console.WriteLine("------------------------------------");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Papel vs ");
            Console.ResetColor();

            if (escolhaComputador == ESCOLHA_TESOURA)
            {
                Console.WriteLine("Tesoura");
                Console.WriteLine("------------------------------------");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("O computador venceu.");
                Console.ResetColor();
            }
            else if (escolhaComputador == ESCOLHA_PEDRA)
            {
                Console.WriteLine("Pedra");
                Console.WriteLine("------------------------------------");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Você venceu.");
                Console.ResetColor();
            }
        }
        else if (escolhaJogador == ESCOLHA_TESOURA)
        {
            Console.WriteLine("------------------------------------");
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("Tesoura vs ");
            Console.ResetColor();

            if (escolhaComputador == ESCOLHA_PEDRA)
            {
                Console.WriteLine("Pedra");
                Console.WriteLine("------------------------------------");
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("O computador venceu.");
                Console.ResetColor();
            }
            else if (escolhaComputador == ESCOLHA_PAPEL)
            {
                Console.WriteLine("Papel");
                Console.WriteLine("------------------------------------");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("Você venceu.");
                Console.ResetColor();
            }
        }
    }
}


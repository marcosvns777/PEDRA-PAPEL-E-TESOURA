using System;

class Program
{
    static void Main()
    {
        string[] opcoes = { "Pedra", "Papel", "Tesoura" };
        Random random = new Random();

        Console.WriteLine("--- Jogo: Pedra, Papel e Tesoura ---");
        Console.WriteLine("Escolha: [0] Pedra, [1] Papel, [2] Tesoura");
        
        // Lê a escolha do jogador
        int escolhaJogador = int.Parse(Console.ReadLine());
        
        // O computador escolhe aleatoriamente (0, 1 ou 2)
        int escolhaComputador = random.Next(0, 3);

        Console.WriteLine($"\nVocê escolheu: {opcoes[escolhaJogador]}");
        Console.WriteLine($"Computador escolheu: {opcoes[escolhaComputador]}");

        // Lógica para decidir o vencedor
        if (escolhaJogador == escolhaComputador)
        {
            Console.WriteLine("Empate!");
        }
        else if ((escolhaJogador == 0 && escolhaComputador == 2) || 
                 (escolhaJogador == 1 && escolhaComputador == 0) || 
                 (escolhaJogador == 2 && escolhaComputador == 1))
        {
            Console.WriteLine("Você venceu! Parabéns!");
        }
        else
        {
            Console.WriteLine("O computador venceu!");
        }
    }
}

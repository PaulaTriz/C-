using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite seu nome: "); // Mostra a mensagem sem pular linha para o usuario digitar do lado
        string nome = Console.ReadLine(); // Le o texto digitado pelo usuario e salva na variavel 'nome'
        Console.WriteLine("Olá, " + nome + "!"); // Junta as palavras e mostra a saudação personalizada
        Console.ReadLine(); // trava o console para que a janela não feche sozinha
    }
}

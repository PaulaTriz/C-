using System;
class Program 
{
    static void Main() 
    {
        Console.Write("Digite sua idade: "); // Solicita a idade ao usuario na mesma linha
        int idade = int.Parse(Console.ReadLine()); // Le o texto do usuario e converte para número inteiro

        if (idade >= 18) // Verifica se a idade é maior ou igual a 18
        {
            Console.WriteLine("Voce é maior de idade."); // Exibe a mensagem caso a condição seja verdadeira 
        }
        else // Caso contrario (menor que 18)
        {
            Console.WriteLine("Voce é menor de idade."); // Exibe a mensagem de manor de idade
        }
        Console.ReadLine(); // Mantém o console aberto aberto aquardando a tecla Enter
    }
}

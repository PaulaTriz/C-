using System;

class Program
{
    static void Main()
    {
        Console.Write("Digite sua idade: ");
        int idade = int.Parse(Console.ReadLine());
        if (idade >= 18)
            Console.WriteLine("Voce é maior de idade.")
                else(idade < 18) 
                Console.WriteLine("Voce é menor de idade.")
            Console.ReadLine();
    }
}

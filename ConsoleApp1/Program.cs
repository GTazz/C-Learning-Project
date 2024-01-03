using System;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main()
    {

        Console.WriteLine("Insira seu nome:");
        var nome = Console.ReadLine();
        Console.Clear();
        Console.WriteLine($"Olá {nome}, seja bem vindo ao MathLearning!");

        int escolha = 0;
        while (escolha != 4)
        {
            Console.WriteLine("\r\nQual tema matemático você gostaria de aprender?");
            Console.WriteLine("1-Tabuada\n2-Sucessor e Antecessor\n3-Média aritimética\n4-Sair do programa");
            escolha = Convert.ToInt32(Console.ReadLine());
            Console.Clear();
         
            //Switch

            switch (escolha)
            {
                case 1:
                    Console.WriteLine("Escolha um número para visualizar sua tabuada.");
                    int tab = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();
                    Console.WriteLine($"Ok, você escolheu a Tabuada do {tab}. Aqui está:");

                    for (int i = 1; i < 11; i++)
                    {
                        Console.WriteLine($"{tab} x {i} = {tab * i}");

                    }
                    break;
                case 2:
                    
                    Console.WriteLine("Escolha um número:");
                    var num = Convert.ToInt32(Console.ReadLine());
                    Console.Clear();

                    int opt = 0;
                    while (0 >= opt || opt >= 4)
                    {
                        Console.WriteLine("Escolha uma das opções:");
                        Console.WriteLine("1-Ver sucessor\n2-ver antecessor\n3-Ver ambos");
                        opt = Convert.ToInt32(Console.ReadLine());

                        Console.Clear();
                        switch (opt) 
                        {
                            case 1:
                                Console.WriteLine($"O Sucessor do seu número é {num + 1}.");
                                break;
                            case 2:
                                Console.WriteLine($"O antecessor do seu número é {num - 1}.");
                                break;
                            case 3:
                                Console.WriteLine($"O Sucessor do seu número é {num + 1}.\nO antecessor do seu número é {num - 1}.");
                                break;
                            default:
                                Console.WriteLine("Opção inválida!");
                                break;
                        }
                    }
                    break;                   
                case 3:
                    Console.WriteLine("Escolha um número:");
                    float numero1 = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Escolha outro número:");
                    float numero2 = Convert.ToInt32(Console.ReadLine());

                    float media = (numero1 + numero2) / 2;

                    Console.WriteLine($"A média de {numero1} e {numero2} é igual a {media}!");
                    break;
                case 4:
                    Console.WriteLine("Obrigado por usar o MathLearning!");
                    break;
                default:
                    Console.WriteLine("Opção inválida!");
                    break;
            }

            Console.ReadLine();
            Console.Clear();

        }
    }
}
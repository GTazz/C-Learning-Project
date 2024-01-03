
Console.WriteLine("Insira seu nome:");
var nome = Console.ReadLine();
Console.Clear();
Console.WriteLine($"Olá {nome}, seja bem vindo ao MathLearning!");
Console.WriteLine("\r\nQual tema matemático você gostaria de aprender?");
Console.WriteLine("1-Tabuada|2-Sucessor e Antecessor|3-Média aritimética|4-Sair do programa");
string escolha = (Console.ReadLine());
Console.Clear();
while (escolha == "4")
{
    Console.WriteLine("Obrigado por usar o MathLearning!");
    break;
}

//If e Else

if (escolha == "1")
{
    Console.WriteLine("Escolha uma tabuada do 1 ao 10.");
    var tab = Convert.ToInt32(Console.ReadLine());
    Console.Clear();
    Console.WriteLine($"Ok, você escolheu a Tabuada do {tab}. Aqui está:");

    if (tab == 1)
    {
        Console.WriteLine(" \r\n 1 x 1 = 1 \r\n 1 x 2 = 2 \r\n 1 x 3 = 3 \r\n 1 x 4 = 4 \r\n 1 x 5 = 5 \r\n 1 x 6 = 6 \r\n 1 x 7 = 7 \r\n 1 x 8 = 8 \r\n 1 x 9 = 9 \r\n 1 x 10 = 10");
    }
    else if (tab == 2)
    {
        Console.WriteLine("\r\n 2 x 1 = 2 \r\n 2 x 2 = 4 \r\n 2 x 3 = 6 \r\n 2 x 4 = 8 \r\n 2 x 5 = 10 \r\n 2 x 6 = 12 \r\n 2 x 7 = 14 \r\n 2 x 8 = 16 \r\n 2 x 9 = 18 \r\n 2 x 10 = 20");
    }
    else if (tab == 3)
    {
        Console.WriteLine("\r\n 1 x 3 = 3 \r\n 2 x 3 = 6 \r\n 3 x 3 = 9 \r\n 4 x 3 = 12 \r\n 5 x 3 = 15 \r\n 6 x 3 = 18 \r\n 7 x 3 = 21 \r\n 9 x 3 = 27 \r\n 10 x 3 = 30");
    }
    else if (tab == 4)
    {
        Console.WriteLine("\r\n 1 x 4 = 4 \r\n 2 x 4 = 8 \r\n 3 x 4 = 12 \r\n 4 x 4 = 16 \r\n 5 x 4 = 20 \r\n 6 x 4 = 24 \r\n 7 x 4 = 28 \r\n 8 x 4 = 32 \r\n 9 x 4 = 36 \r\n 10 x 4 = 40");
    }
    else if (tab == 5)
    {
        Console.WriteLine("\r\n 1 x 5 = 5 \r\n 2 x 5 = 10 \r\n 3 x 5 = 15 \r\n 4 x 5 = 20 \r\n 5 x 5 = 25 \r\n 6 x 5 = 30 \r\n 7 x 5 = 35  \r\n 8 x 5 = 40 \r\n 9 x 5 = 45 \r\n 10 x 5 = 50");
    }
    else if (tab == 6)
    {
        Console.WriteLine("\r\n 1 x 6 = 6 \r\n 2 x 6 = 12 \r\n 3 x 6 = 18 \r\n 4 x 6 = 24 \r\n 5 x 6 = 30 \r\n 6 x 6 = 36 \r\n 7 x 6 = 42 \r\n 8 x 6 = 48 \r\n 9 x 6 = 54 \r\n 10 x 6 = 60");
    }
    else if (tab == 7)
    {
        Console.WriteLine("\r\n 1 x 7 = 7 \r\n 2 x 7 = 14 \r\n 3 x 7 = 21 \r\n 4 x 7 = 28 \r\n 5 x 7 = 35 \r\n 6 x 7 = 42 \r\n 7 x 7 = 49 \r\n 8 x 7 = 56 \r\n 9 x 7 = 63 \r\n 10 x 7 = 70");
    }
    else if (tab == 8)
    {
        Console.WriteLine("\r\n 1 x 8 = 8 \r\n 2 x 8 = 16 \r\n 3 x 8 = 24 \r\n 4 x 8 = 32 \r\n 5 x 8 = 40 \r\n 6 x 8 = 48 \r\n 7 x 8 = 56 \r\n 8 x 8 = 64 \r\n 9 x 8 = 72 \r\n 10 x 8 = 80");
    }
    else if (tab == 9)
    {
        Console.WriteLine("\r\n 1 x 9 = 09 \r\n 2 x 9 = 18 \r\n 3 x 9 = 27 \r\n 4 x 9 = 36 \r\n 5 x 9 = 45 \r\n 6 x 9 = 54 \r\n 7 x 9 = 63 \r\n 8 x 9 = 72 \r\n 9 x 9 = 81 \r\n 10 x 9 = 90");
    }
    else if (tab == 10)
    {
        Console.WriteLine("\r\n 1 x 10 = 10 \r\n 2 x 10 = 20 \r\n 3 x 10 = 30 \r\n 4 x 10 = 40 \r\n 5 x 10 = 50 \r\n 6 x 10 = 60 \r\n 7 x 10 = 70 \r\n 8 x 10 = 80 \r\n 9 x 10 = 90 \r\n 10 x 9 = 100");
    }
}
else if (escolha == "2")
{
    while (escolha.ToUpper() != "4")
    {
        Console.WriteLine("Escolha um número:");
        var num = Convert.ToInt32(Console.ReadLine());
        Console.Clear();

        Console.WriteLine("Deseja ver seu sucessor, e antecessor? Sim/Não");
        string resp1 = Console.ReadLine();
        Console.Clear();

        if (resp1 == "Sim")
        {
            num = num + 1;
            Console.WriteLine($"O Sucessor do seu número é {num}.");
            Console.WriteLine("Informe seu número novamente:");
            var num2 = Convert.ToInt32(Console.ReadLine());
            num2 = num2 - 1;
            Console.WriteLine($"O antecessor do seu número é {num2}.");
            break;

        }
        else if (resp1 == "Não")
        {
            Console.WriteLine("Obrigado por usar o MathLearning!");
            break;
        }
    }
}
else if (escolha == "3")
{
    Console.WriteLine("Escolha um número:");
    float numero1 = Convert.ToInt32(Console.ReadLine());
    Console.WriteLine("Escolha outro número:");
    float numero2 = Convert.ToInt32(Console.ReadLine());
    float media;

    media = (numero1 + numero2) / 2;

    Console.WriteLine($"A média de {numero1} e {numero2} é igual a {media}!");
}

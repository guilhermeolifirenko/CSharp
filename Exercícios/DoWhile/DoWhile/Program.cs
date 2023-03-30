/*
    int x = int.Parse(Console.ReadLine());
    int soma = 0;

    while (x != 0)
    {
        soma += x;
        x = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("A soma dos números digitados é: " + soma);
 */

    double idade, soma, media;
    int count;

    idade = double.Parse(Console.ReadLine());

    soma = 0.0;
    count = 0;

    while (idade >= 0)
    {
        soma += idade; 
        count += 1;
        idade = double.Parse(Console.ReadLine());
    }

    if (count == 0)
    {
        Console.WriteLine("Impossível calcular!");
    }
    else
    {
        media = soma / count;
        Console.WriteLine("A média aritimética das idades é: " + media.ToString("F2"));
    }
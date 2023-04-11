double C, F;
char verificar;

do
{
    Console.Write("Digite a temperatura em Celcius: ");
    C = double.Parse(Console.ReadLine());
    F = 9.0 * C / 5.0 + 32.0;
    Console.WriteLine("Equivalente em Fahrenheit: " + F.ToString("F1"));
    Console.Write("Deseja repetir (s/n)? ");
    verificar = char.Parse(Console.ReadLine());
} while (verificar == 's');

Console.ReadLine();
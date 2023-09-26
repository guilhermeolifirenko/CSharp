/* int N = int.Parse(Console.ReadLine());

for (int i = 1; i <= 10; i++)
{
    int resultado;
    resultado = i * N;
    Console.WriteLine(i + " x " + N + " = " + resultado);
}

Console.ReadLine();
*/

double soma = 0;

for (int i = 1; i <= 100; i++)
{
    soma = soma + 1.0 / i;
}

Console.WriteLine(soma.ToString("F2"));
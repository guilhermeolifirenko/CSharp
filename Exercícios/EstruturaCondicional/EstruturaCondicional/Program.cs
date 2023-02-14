/*
 * double a, b, soma;
 *
 *   a = double.Parse(Console.ReadLine());
 *   b = double.Parse(Console.ReadLine());
 *   soma = a + b;
 *
 *   Console.WriteLine("NOTA = " + soma.ToString("F1"));
 *
 *   if ( soma < 60.0)
 *   {
 *       Console.WriteLine("REPROVADO");
 *   } else
 *   {
 *       Console.WriteLine("APROVADO");
 *   }
 *
 *   int a, b, c;
 *
 *  string[] vet = Console.ReadLine().Split(' ');
 *   a = int.Parse(vet[0]);
 *   b = int.Parse(vet[1]);
 *   c = int.Parse(vet[2]);
 *
 *   if (a < b && a < c)
 *   {
 *       Console.WriteLine("MENOR = " + a);
 *   }
 *   else if (b < c)
 *   {
 *       Console.WriteLine("MENOR = " + b);
 *   }
 *   else
 *   {
 *       Console.WriteLine("MENOR = " + c);
 *   }
 */

int minutos;
double conta;

minutos = int.Parse(Console.ReadLine());
conta = 50.0;

if (minutos >= 100)
{
    conta += (minutos - 100) * 2.0;
}

Console.WriteLine("Valor a pagar: R$ " + conta.ToString("F2"));

Console.ReadLine();
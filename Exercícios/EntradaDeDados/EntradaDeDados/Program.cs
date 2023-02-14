/* 
 *  string frase = Console.ReadLine();
 *   string x = Console.ReadLine();
 *   string y = Console.ReadLine();
 *   string z = Console.ReadLine();
 *
 *   // Split
 *   string[] vetor = Console.ReadLine().Split(',');
 *
 *   string a = vetor[0];
 *   string b = vetor[1];
 *   string c = vetor[2];
 *
 *
 *   Console.WriteLine();
 *   Console.WriteLine("Você escreveu:");
 *   Console.WriteLine(frase);
 *   Console.WriteLine();
 *   Console.WriteLine(x);
 *   Console.WriteLine(y);
 *   Console.WriteLine(z);
 *   Console.WriteLine();
 *   Console.WriteLine(a);
 *   Console.WriteLine(b);
 *   Console.WriteLine(c);
 */

int n1 = int.Parse(Console.ReadLine());
char ch = char.Parse(Console.ReadLine());
double n2 = double.Parse(Console.ReadLine());

Console.WriteLine("Você digitou: ");
Console.WriteLine(n1);
Console.WriteLine(ch);
Console.WriteLine(n2);
Console.WriteLine();

string[] vetor = Console.ReadLine().Split(' ');
string nome = vetor[0];
char sexo = char.Parse(vetor[1]);
int idade = int.Parse(vetor[2]);
double altura = double.Parse(vetor[3]);

Console.WriteLine("Nome: " + nome);
Console.WriteLine("Sexo: " + sexo);
Console.WriteLine("Idade: " + idade);
Console.WriteLine("Altura: " + altura);
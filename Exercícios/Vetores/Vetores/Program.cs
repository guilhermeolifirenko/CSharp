/*
int N = int.Parse(Console.ReadLine());

double[] vet;
vet = new double[N];

for (int i = 0; i < N; i++)
{
    vet[i] = double.Parse(Console.ReadLine());
}

Console.WriteLine();
Console.WriteLine("Os números digitados foram:");
Console.WriteLine();

for (int i = 0; i < N; i++)
{
    Console.WriteLine(vet[i].ToString("F1"));
}

int N = int.Parse(Console.ReadLine());
int[] vet = new int[N];

string[] s = Console.ReadLine().Split(' ');

for (int i = 0; i < N; i++)
{
    vet[i] = int.Parse(s[i]);
}

for (int i = 0; i < N; i++)
{
    if (vet[i] < 0)
    {
        Console.WriteLine(vet[i]);
    }
}

int N = int.Parse(Console.ReadLine());
double[] vet = new double[N];

string[] s = Console.ReadLine().Split(' ');

for (int i = 0; i < N; i++)
{
    vet[i] = double.Parse(s[i]);
}

for (int i = 0; i < N; i++)
{
    Console.Write(vet[i].ToString("F1") + " ");
}

Console.WriteLine(); 

double soma = 0.0;
for (int i = 0; i < N; i++)
{
    soma += vet[i];
}

double media = soma / N;

Console.WriteLine(soma.ToString("F2"));
Console.WriteLine(media.ToString("F2"));
*/

int N = int.Parse(Console.ReadLine());

string[] nomes = new string[N];
int[] idades = new int[N];
double[] alturas = new double[N];

for (int i = 0; i < N; i++)
{
    string[] s = Console.ReadLine().Split(' ');
    nomes[i] = s[0];
    idades[i] = int.Parse(s[1]);
    alturas[i] = double.Parse(s[2]);

}

double soma = 0.0;
for (int i = 0; i < N; i++)
{
    soma += alturas[i];
}
double media = soma / N;

Console.WriteLine("Altura média: " + media.ToString("F2"));

int count = 0;
for (int i = 0; i < N; i++)
{
    if (idades[i] < 16)
    {
        count++;
    }
}
double porcentagem = (double)count / N * 100;

Console.WriteLine("Pessoas com menos de 16 anos: " + porcentagem.ToString("F1") + "%");
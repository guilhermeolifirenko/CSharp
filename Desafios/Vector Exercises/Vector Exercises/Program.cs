/*
 
// Exercício 1 - Maior Número
 
int N = int.Parse(Console.ReadLine());

double[] numeros = new double[N];
string[] vet = Console.ReadLine().Split(' ');


for (int i = 0; i < N; i++)
{
    numeros[i] = double.Parse(vet[i]);
}

double maior = numeros[0];
int posicaoMaior = 0;

for (int i = 1; i < N; i++)
{
    if (numeros[i] > maior)
    {
        maior = numeros[i];
        posicaoMaior = i;
    }
}

Console.WriteLine(maior.ToString("F1"));
Console.WriteLine(posicaoMaior);

// Exercício 2 - Números Pares

int N = int.Parse(Console.ReadLine());

int[] numeros = new int[N];
string[] valores = Console.ReadLine().Split(" ");

for (int i = 0; i < N; i++)
{
    numeros[i] = int.Parse(valores[i]);
}

int count = 0;
for (int i = 0; i < N; i++)
{
    if (numeros[i] % 2 == 0)
    {
        Console.Write(numeros[i] + " ");
        count++;
    }
}
Console.WriteLine();
Console.WriteLine(count);

// Exercício 3 -  Soma de Vetores

int N = int.Parse(Console.ReadLine());

int[] A = new int[N];
int[] B = new int[N];
int[] C = new int[N];

string[] numA = Console.ReadLine().Split(" ");
string[] numB = Console.ReadLine().Split(" ");

for (int i = 0; i < N; i++)
{
    A[i] = int.Parse(numA[i]);
    B[i] = int.Parse(numB[i]);
}

// Soma Dos Vetores A e B
for (int i = 0; i < N; i++)
{
    C[i] = A[i] + B[i];
    //Console.Write(C[i] + " ");
}

foreach (int num in C)
{
    Console.Write(num + " ");
}

// Exercício 4 - Média Aritmética

int N = int.Parse(Console.ReadLine());

double[] num = new double[N];
string[] numeros = Console.ReadLine().Split(" ");

for (int i = 0; i < N; i++)
{
    num[i] = double.Parse(numeros[i]);
}

// Média aritmética
int count = 0;
double sum = 0.0;
for (int i = 0; i < N; i++)
{
    sum += num[i];
    count++;
}
double media = (double)sum / count;

Console.WriteLine(media.ToString("F3"));

// Menor que a média aritmética
for (int i = 0; i < N; i++)
{
    if (num[i] < media)
    {
        Console.WriteLine(num[i]);
    }
}

// Exercício 5 - Média Aritmética com Pares

int N = int.Parse(Console.ReadLine());

int[] num = new int[N];
string[] values = Console.ReadLine().Split(' ');

for (int i = 0; i < N; i++)
{
    num[i] = int.Parse(values[i]);
}


int count = 0;
int soma = 0;
for (int i = 0; i < N; i++)
{
    if (num[i] % 2 == 0)
    {
        soma += num[i];
        count++;
    }
}

double media = (double)soma / count;
Console.WriteLine(media.ToString("F1"));

// Exercício 6 - Pessoa Mais Velha

int N = int.Parse(Console.ReadLine());

string[] nomes = new string[N];
int[] idades = new int[N];

for (int i = 0; i < N; i++)
{
    string[] dados = Console.ReadLine().Split(' ');

    nomes[i] = dados[0];
    idades[i] = int.Parse(dados[1]);
}

int maisVelha = idades[0];
int posicao = 0;
for (int i = 0; i < N; i++)
{
    if (idades[i] > maisVelha)
    {
        maisVelha = idades[i];
        posicao = i;
    }
}

Console.WriteLine("Pessoa mais velha: " + nomes[posicao]);

// Exercício 7 - Alunos Aprovados

int N = int.Parse(Console.ReadLine());

string[] nomes = new string[N];
double[] notas1 = new double[N];
double[] notas2 = new double[N];

for (int i = 0; i < N; i++)
{
    string[] dados = Console.ReadLine().Split(' ');

    nomes[i] = dados[0];
    notas1[i] = double.Parse(dados[1]);
    notas2[i] = double.Parse(dados[2]);

}

Console.WriteLine("Alunos aprovados:");

for (int i = 0; i < N; i++)
{
    double media = (notas1[i] + notas2[i]) / 2.0;

    if (media >= 6.0)
    {
        Console.WriteLine(nomes[i]);
    }
}

// Exercício 8 - Altura e Sexo

int N = int.Parse(Console.ReadLine());

double[] alturas = new double[N];
char[] sexos = new char[N];

for (int i = 0; i < N; i++)
{
    string[] dados = Console.ReadLine().Split(' ');

    alturas[i] = double.Parse(dados[0]);
    sexos[i] = char.Parse(dados[1]);

}

double maior = 0.0;
double menor = alturas[0];
for (int i = 0; i < N; i++)
{
    if (maior < alturas[i])
    {
        maior = alturas[i];
    }
    
    if (menor > alturas[i])
    {
        menor = alturas[i];
    }
}

double soma = 0.0;
int count = 0;
int homens = 0;
for (int i = 0; i < N; i++)
{
    if (sexos[i] == 'F')
    {
        soma += alturas[i];
        count++;
    }

    if (sexos[i] == 'M')
    {
        homens++;
    }

}
double media = soma / count;

Console.WriteLine("Menor altura = " + menor.ToString("F2"));
Console.WriteLine("Maior altura = " + maior.ToString("F2"));
Console.WriteLine("Media das alturas das mulheres = " + media.ToString("F2"));
Console.WriteLine("Numero de homens = " + homens);
*/
// Exercício 9 - Lucro das Mercadorias

int N = int.Parse(Console.ReadLine());

string[] nomeProdutos = new string[N];
double[] valCompras = new double[N];
double[] valVendas = new double[N];

for (int i = 0; i < N; i++)
{
    string[] dados = Console.ReadLine().Split(" ");

    nomeProdutos[i] = dados[0];
    valCompras[i] = double.Parse(dados[1]);
    valVendas[i]  = double.Parse(dados[2]);

}

int contAbaixoDe10 = 0;
int contEntre10E20 = 0;
int contAcimaDe20 = 0;
for (int i = 0; i < N; i++)
{
    double lucro = valVendas[i] - valCompras[i];

    double porcentagemDeLucro = lucro / valCompras[i] * 100.0;

    if (porcentagemDeLucro < 10.0)
    {
        contAbaixoDe10++;
    }
    else if (porcentagemDeLucro <= 20)
    {
        contEntre10E20++;
    }
    else
    {
        contAcimaDe20++;
    }
}

Console.WriteLine("Lucro abaixo de 10¨: " + contAbaixoDe10);
Console.WriteLine("Lucro entre 10% e 20%: " + contEntre10E20);
Console.WriteLine("Lucro acima de 20%: " + contAcimaDe20);

double totalCompra = 0.0;
double totalVenda = 0.0;
for(int i = 0; i < N; i++)
{

    totalCompra += valCompras[i];
    totalVenda += valVendas[i];

}

double totalLucro = totalVenda - totalCompra;

Console.WriteLine("Valor total de compra: " + totalCompra.ToString("F2"));
Console.WriteLine("Valor total de venda: " + totalVenda.ToString("F2"));
Console.WriteLine("Lucro total: " + totalLucro.ToString("F2"));
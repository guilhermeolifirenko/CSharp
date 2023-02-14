double x = 5.0;
double y = 9.0;
double z = -10.0;
double A, B, C;

A = Math.Sqrt(x);
B = Math.Sqrt(y);
C = Math.Sqrt(25.0);

Console.WriteLine("A raiz quadrada de " + x + " = " + A);
Console.WriteLine();
Console.WriteLine("A raiz quadrada de " + y + " = " + B);
Console.WriteLine();
Console.WriteLine("A raiz quadrada de 25 = " + C);
Console.WriteLine();

A = Math.Pow(x, y);
B = Math.Pow(y, 2.0);

Console.WriteLine(x + " elevado a " + y + " = " + A);
Console.WriteLine();
Console.WriteLine(x + " elevado ao quadrado = " + B);
Console.WriteLine();

A = Math.Abs(y);
B = Math.Abs(z);

Console.WriteLine("O valor absoluto de " + y + " = " + A);
Console.WriteLine();
Console.WriteLine("O valor absoluto de " + z + " = " + B);

// URI 1013

int a, b, c, maiorAB, maior;
    
string[] vetor = Console.ReadLine().Split(' ');
    
a = int.Parse(vetor[0]);
b = int.Parse(vetor[1]);
c = int.Parse(vetor[2]);
    
maiorAB = (a + b + Math.Abs(a-b)) / 2;
maior = (maiorAB + c + Math.Abs(maiorAB - c)) / 2;

Console.WriteLine(maior + " eh o maior");

// URI 1012

double A, B, C, TRIANGULO, CIRCULO, TRAPEZIO, QUADRADO, RETANGULO;
    
string[] vetor = Console.ReadLine().Split(' ');
A = double.Parse(vetor[0]);
B = double.Parse(vetor[1]);
C = double.Parse(vetor[2]);
    
TRIANGULO = A * C / 2;
CIRCULO = 3.14159 * Math.Pow(C, 2.0);
TRAPEZIO = (A + B) * C / 2;
QUADRADO = Math.Pow(B, 2.0);
RETANGULO = A * B;
    
Console.WriteLine("TRIANGULO: " + TRIANGULO.ToString("F3"));
Console.WriteLine("CIRCULO: " + CIRCULO.ToString("F3"));
Console.WriteLine("TRAPEZIO: " + TRAPEZIO.ToString("F3"));
Console.WriteLine("QUADRADO: " + QUADRADO.ToString("F3"));
Console.WriteLine("RETANGULO: " + RETANGULO.ToString("F3"));

// URI 1015
double x1, x2, y1, y2, distancia;
    
string[] valores = Console.ReadLine().Split(' ');
x1 = double.Parse(valores[0]);
y1 = double.Parse(valores[1]);
    
valores = Console.ReadLine().Split(' ');
x2 = double.Parse(valores[0]);
y2 = double.Parse(valores[1]);
    
distancia = Math.Sqrt(Math.Pow(x2 - x1, 2.0) + Math.Pow(y2 - y1, 2.0));
    
Console.WriteLine(distancia.ToString("F4"));
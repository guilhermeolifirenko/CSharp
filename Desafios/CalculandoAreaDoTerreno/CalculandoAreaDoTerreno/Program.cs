double largura, comprimento, area, precoMetroQuadrado, preco;

largura = double.Parse(Console.ReadLine());
comprimento = double.Parse(Console.ReadLine());
precoMetroQuadrado = double.Parse(Console.ReadLine());

area = largura * comprimento;
preco = area * precoMetroQuadrado;

Console.WriteLine("Área = " + area.ToString("F2"));
Console.WriteLine("Preço = " + preco.ToString("F2"));
Console.ReadLine();
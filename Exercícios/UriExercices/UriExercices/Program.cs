/*
 *    // URI 1040
 *
 *   float N1, N2, N3, N4, media, notaExame, mediaFinal;
 *
 *   string[] valores = Console.ReadLine().Split(' ');
 *   N1 = float.Parse(valores[0]);
 *   N2 = float.Parse(valores[1]);
 *   N3 = float.Parse(valores[2]);
 *   N4 = float.Parse(valores[3]);
 *
 *   media = (N1 * 2 + N2 * 3 + N3 * 4 + N4 * 1) / 10;
 *
 *   if (media == 4.85f)
 *   {
 *       media = 4.8f;
 *   }
 *
 *   Console.WriteLine("Media: " + media.ToString("F1"));
 *
 *   if (media >= 7.0)
 *   {
 *       Console.WriteLine("Aluno aprovado.");
 *   }
 *   else if (media < 5.0)
 *   {
 *       Console.WriteLine("Aluno reprovado.");
 *   }
 *   else
 *   {
 *       Console.WriteLine("Aluno em exame.");
 *       notaExame = float.Parse(Console.ReadLine());
 *       Console.WriteLine("Nota do exame: " + notaExame.ToString("F1"));
 *       mediaFinal = (media + notaExame) / 2;
 *       if (mediaFinal >= 5.0)
 *       {
 *           Console.WriteLine("Aluno aprovado.");
 *       }
 *       else
 *       {
 *           Console.WriteLine("Aluno reprovado.");
 *       }
 *       Console.WriteLine("Media final: " + mediaFinal.ToString("F1"));
 *   }
 *
 *   // URI 1041
 *
 *   double x, y;
 *
 *   string[] xy = Console.ReadLine().Split(' ');
 *   x = double.Parse(xy[0]);
 *   y = double.Parse(xy[1]);
 *
 *   if (x == 0.0 && y == 0.0)
 *   {
 *       Console.WriteLine("Origem");
 *   }
 *   else if (x == 0.0)
 *   {
 *       Console.WriteLine("Eixo Y");
 *   }
 *   else if (y == 0.0)
 *   {
 *       Console.WriteLine("Eixo X");
 *   }
 *   else if (x > 0.0 && y > 0.0)
 *   {
 *       Console.WriteLine("Q1");
 *   }
 *   else if (x < 0.0 && y > 0.0)
 *   {
 *       Console.WriteLine("Q2");
 *   }
 *   else if (x < 0.0 && y < 0.0)
 *   {
 *       Console.WriteLine("Q3");
 *   }
 *   else
 *   {
 *       Console.WriteLine("Q4");
 *   }
 *
 *   // URI 1047
 *  
 *   string[] tempo = Console.ReadLine().Split(' ');
 *   int horaInicial = int.Parse(tempo[0]);
 *   int minutoInicial = int.Parse(tempo[1]);
 *   int horaFinal = int.Parse(tempo[2]);
 *   int minutoFinal = int.Parse(tempo[3]);
 *
 *   int instanteInicial = horaInicial * 60 + minutoInicial;
 *   int instanteFinal = horaFinal * 60 + minutoFinal;
 *       
 *   int duracao;
 *   if (instanteInicial < instanteFinal)
 *   {
 *       duracao = instanteFinal - instanteInicial;
 *   }
 *   else
 *   {
 *       duracao = (24 * 60 - instanteInicial) + instanteFinal;
 *   }
 *
 *   int duracaoHoras = duracao / 60;
 *   int duracaoMinutos = duracao % 60;
 *
 *   Console.WriteLine("O JOGO DUROU " + duracaoHoras + " HORA(S) E " + duracaoMinutos + " MINUTO(S)");
 *
 *   // URI 1048
 *
 *   double salario = double.Parse(Console.ReadLine());
 *
 *   double percentual;
 *   if (salario <= 400.0)
 *   {
 *       percentual = 15.0;
 *   }
 *   else if (salario <= 800.0)
 *   {
 *       percentual = 12.0;
 *   }
 *   else if (salario <= 1200.0)
 *   {
 *       percentual = 10.0;
 *   }
 *   else if (salario <= 2000.0)
 *   {
 *       percentual = 7.0;
 *   }
 *   else
 *   {
 *       percentual = 4.0;
 *   }
 *
 *   double reajuste = salario * percentual / 100.0;
 *   double novoSalario = salario + reajuste;
 *
 *   Console.WriteLine("Novo salario: " + novoSalario.ToString("F2"));
 *   Console.WriteLine("Reajuste ganho: " + reajuste.ToString("F2"));
 *   Console.WriteLine("Em percentual: " + percentual.ToString("F0") + " %");
 *
 *   // URI 1051
 *
 *   double salario = double.Parse(Console.ReadLine());
 *
 *   double imposto;
 *   if (salario <= 2000.0)
 *   {
 *       imposto = 0.0;
 *   }
 *   else if (salario <= 3000.0)
 *   {
 *       imposto = (salario - 2000.0) * 0.08;
 *   }
 *   else if (salario <= 4500.0)
 *   {
 *       imposto = (salario - 3000.0) * 0.18 + 1000.0 * 0.08;
 *   }
 *   else
 *   {
 *       imposto = (salario - 4500.0) * 0.28 + 1500.0 * 0.18 + 1000.0 * 0.08;
 *   }
 *
 *   if (imposto == 0.0)
 *   {
 *       Console.WriteLine("Isento");
 *   }
 *   else
 *   {
 *       Console.WriteLine("R$ " + imposto.ToString("F2"));
 *   }
 */
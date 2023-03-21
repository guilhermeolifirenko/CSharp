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
 */

    double x, y;

    string[] xy = Console.ReadLine().Split(' ');
    x = double.Parse(xy[0]);
    y = double.Parse(xy[1]);

    if (x == 0 && y == 0)
    {
        Console.WriteLine("Origem");
    }
    else if (x > 0 && y > 0)
    {
        Console.WriteLine("Q1");
    }
    else if (x < 0 && y > 0)
    {
        Console.WriteLine("Q2");
    }
    else if (x > 0 && y < 0)
    {
        Console.WriteLine("Q4");
    }
    else
    {
        Console.WriteLine("Q3");
    }

    Console.ReadLine();
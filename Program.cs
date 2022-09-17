Console.Clear();
Console.WriteLine("Texto a ser traduzido: \n");

string texto = Console.ReadLine()!;
string leet = texto.Replace("a","4")
                   .Replace("A","4")
                   .Replace("á","4")
                   .Replace("Á","4")
                   .Replace("à","4")
                   .Replace("À","4")
                   .Replace("ã","4")
                   .Replace("Ã","4")
                   .Replace("â","4")
                   .Replace("Â","4")
                   .Replace("e","3")
                   .Replace("E","3")
                   .Replace("é","3")
                   .Replace("É","3")
                   .Replace("ê","3")
                   .Replace("Ê","3")
                   .Replace("i","1")
                   .Replace("I","1")
                   .Replace("í","1")
                   .Replace("Í","1")
                   .Replace("L","1")
                   .Replace("l","1")
                   .Replace("o","0")
                   .Replace("O","0")
                   .Replace("õ","0")
                   .Replace("Õ","0")
                   .Replace("ô","0")
                   .Replace("Ô","0")
                   .Replace("ó","0")
                   .Replace("Ó","0")
                   .Replace("t","7")
                   .Replace("T","7")
                   .Replace("s","5")
                   .Replace("S","5");

Console.Clear();

Console.ForegroundColor = ConsoleColor.DarkGreen;
Console.WriteLine("Texto em LEET:");
Console.ResetColor();

Console.WriteLine($"\n{leet}\n");

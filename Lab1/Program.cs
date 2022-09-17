Console.WriteLine("Mata in en sträng:");
string input = Console.ReadLine();
Console.WriteLine();
long sum = 0;

for (int i = 0; i < input.Length; i++)
{ 
    // Testa om karaktären är en siffra
    if (char.IsDigit(input[i]))
    {
        // Hitta nästa av samma siffra
        int endOfCombo = input.IndexOf(input[i], i + 1);

        if (endOfCombo != -1)
        {
            // Testa om sifferkombinationen bara innehåller siffror
            string combo = input.Substring(i, endOfCombo - i + 1);
            bool result = long.TryParse(combo, out long numberCombo);

            // Om den gör det, skriv ut med sifferkombination i annan färg samt lägg till summan
            if (result)
            {
                for (int j = 0; j < input.Length; j++)
                {
                    if (j >= i && j <= endOfCombo)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(input[j]);
                        Console.ForegroundColor = ConsoleColor.White;
                    }
                    else
                    {
                        Console.Write(input[j]);
                    }
                }

                Console.WriteLine();
                sum += numberCombo;
            }
        }
    }
}

Console.WriteLine();
Console.WriteLine($"Total: {sum}");

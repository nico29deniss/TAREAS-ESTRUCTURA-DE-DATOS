using System;

class Program
{
    static void Main(string[] args)
    {
        // Pide al usuario una palabra
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine();

        // Contar las veces que cada vocal aparece
        int[] conteoVocales = new int[5]; // a, e, i, o, u

        foreach (char c in palabra.ToLower())
        {
            switch (c)
            {
                case 'a': conteoVocales[0]++; break;
                case 'e': conteoVocales[1]++; break;
                case 'i': conteoVocales[2]++; break;
                case 'o': conteoVocales[3]++; break;
                case 'u': conteoVocales[4]++; break;
            }
        }

        Console.WriteLine("Conteo de vocales:");
        Console.WriteLine($"A: {conteoVocales[0]}");
        Console.WriteLine($"E: {conteoVocales[1]}");
        Console.WriteLine($"I: {conteoVocales[2]}");
        Console.WriteLine($"O: {conteoVocales[3]}");
        Console.WriteLine($"U: {conteoVocales[4]}");
    }
}

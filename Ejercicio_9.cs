using System;

class ContadorVocales
{
    public string Palabra { get; set; }

    public ContadorVocales(string palabra)
    {
        Palabra = palabra.ToLower(); // Convertir a minúsculas
    }

    public void ContarVocales()
    {
        int aCount = 0, eCount = 0, iCount = 0, oCount = 0, uCount = 0;

        foreach (char letra in Palabra)
        {
            switch (letra)
            {
                case 'a': aCount++; break;
                case 'e': eCount++; break;
                case 'i': iCount++; break;
                case 'o': oCount++; break;
                case 'u': uCount++; break;
            }
        }

        Console.WriteLine($"A: {aCount}");
        Console.WriteLine($"E: {eCount}");
        Console.WriteLine($"I: {iCount}");
        Console.WriteLine($"O: {oCount}");
        Console.WriteLine($"U: {uCount}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine();

        ContadorVocales contador = new ContadorVocales(palabra);
        contador.ContarVocales();
    }
}

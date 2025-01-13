using System;

class Palindromo
{
    public string Palabra { get; set; }

    public Palindromo(string palabra)
    {
        Palabra = palabra.ToLower(); // Convertir a minúsculas
    }

    public bool EsPalindromo()
    {
        char[] array = Palabra.ToCharArray();
        Array.Reverse(array);
        string palabraReversa = new string(array);

        return Palabra == palabraReversa;
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine();
        
        Palindromo palindromo = new Palindromo(palabra);

        if (palindromo.EsPalindromo())
        {
            Console.WriteLine("La palabra es un palíndromo.");
        }
        else
        {
            Console.WriteLine("La palabra no es un palíndromo.");
        }
    }
}

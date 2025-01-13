using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Ingrese una palabra: ");
        string palabra = Console.ReadLine().ToLower(); // Convertir a minúsculas

        // Comparar la palabra con su reverso
        char[] array = palabra.ToCharArray();
        Array.Reverse(array);
        string palabraReversa = new string(array);

        if (palabra == palabraReversa)
        {
            Console.WriteLine("La palabra es un palíndromo.");
        }
        else
        {
            Console.WriteLine("La palabra no es un palíndromo.");
        }
    }
}

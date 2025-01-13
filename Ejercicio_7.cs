using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Almacenar el abecedario en una lista
        List<char> abecedario = new List<char>("abcdefghijklmnopqrstuvwxyz");

        // Eliminar letras en posiciones múltiplos de 3
        abecedario.RemoveAll((_, i) => (i + 1) % 3 == 0);

        // Mostrar la lista resultante
        Console.WriteLine("Abecedario sin posiciones múltiplos de 3:");
        foreach (char letra in abecedario)
        {
            Console.Write(letra + " ");
        }
    }
}

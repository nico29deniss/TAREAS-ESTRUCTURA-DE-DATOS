using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> vector1 = new List<int> { 1, 2, 3 };
        List<int> vector2 = new List<int> { -1, 0, 2 };

        if (vector1.Count != vector2.Count)
        {
            Console.WriteLine("Los vectores deben tener la misma longitud.");
            return;
        }

        int productoEscalar = 0;

        for (int i = 0; i < vector1.Count; i++)
        {
            productoEscalar += vector1[i] * vector2[i];
        }

        Console.WriteLine($"El producto escalar de los vectores es: {productoEscalar}");
    }
}

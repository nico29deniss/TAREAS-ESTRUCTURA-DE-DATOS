using System;
using System.Collections.Generic;

class ProductoEscalar
{
    public List<int> V1 { get; set; }
    public List<int> V2 { get; set; }

    public ProductoEscalar(List<int> v1, List<int> v2)
    {
        V1 = v1;
        V2 = v2;
    }

    public int CalcularProductoEscalar()
    {
        if (V1.Count != V2.Count)
        {
            throw new InvalidOperationException("Los vectores deben tener la misma longitud.");
        }

        int productoEscalar = 0;

        for (int i = 0; i < V1.Count; i++)
        {
            productoEscalar += V1[i] * V2[i];
        }

        return productoEscalar;
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<int> vector1 = new List<int> { 1, 2, 3 };
        List<int> vector2 = new List<int> { -1, 0, 2 };

        ProductoEscalar producto = new ProductoEscalar(vector1, vector2);
        int resultado = producto.CalcularProductoEscalar();
        
        Console.WriteLine($"El producto escalar de los vectores es: {resultado}");
    }
}

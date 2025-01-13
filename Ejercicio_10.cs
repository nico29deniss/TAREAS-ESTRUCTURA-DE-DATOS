using System;
using System.Collections.Generic;

class Precios
{
    public List<int> ListaPrecios { get; set; }

    public Precios(List<int> precios)
    {
        ListaPrecios = precios;
    }

    public void MostrarMenorYMayor()
    {
        int menorPrecio = int.MaxValue;
        int mayorPrecio = int.MinValue;

        foreach (int precio in ListaPrecios)
        {
            if (precio < menorPrecio) menorPrecio = precio;
            if (precio > mayorPrecio) mayorPrecio = precio;
        }

        Console.WriteLine($"El menor precio es: {menorPrecio}");
        Console.WriteLine($"El mayor precio es: {mayorPrecio}");
    }
}

class Program
{
    static void Main(string[] args)
    {
        List<int> precios = new List<int> { 50, 75, 46, 22, 80, 65, 8 };
        Precios preciosObj = new Precios(precios);
        preciosObj.MostrarMenorYMayor();
    }
}

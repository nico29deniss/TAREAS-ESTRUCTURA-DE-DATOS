using System;
using System.Collections.Generic;

class Abecedario
{
    public List<char> Letras { get; set; }

    public Abecedario()
    {
        Letras = new List<char> {'A', 'B', 'C', 'D', 'E', 'F', 'G', 'H', 'I', 'J', 'K', 'L', 'M', 'N', 'O', 'P', 'Q', 'R', 'S', 'T', 'U', 'V', 'W', 'X', 'Y', 'Z'};
    }

    public void EliminarPosicionesMultiploDeTres()
    {
        for (int i = Letras.Count - 1; i >= 0; i--)
        {
            if ((i + 1) % 3 == 0) // Las posiciones son de base 0, por eso sumamos 1
            {
                Letras.RemoveAt(i);
            }
        }
    }

    public void MostrarLetras()
    {
        foreach (char letra in Letras)
        {
            Console.Write(letra + " ");
        }
        Console.WriteLine();
    }
}

class Program
{
    static void Main(string[] args)
    {
        Abecedario abecedario = new Abecedario();
        abecedario.EliminarPosicionesMultiploDeTres();
        abecedario.MostrarLetras();
    }
}

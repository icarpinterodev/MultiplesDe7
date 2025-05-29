using System;
using System.Collections.Generic;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.Write("Introdueix un número límit: ");
        int limit = int.Parse(Console.ReadLine());
        List<int> multiples = Metodes.ComptadorMultiples(limit);
        Console.WriteLine("Múltiples de 7:");
        Console.WriteLine(string.Join(", ", multiples));
        Console.WriteLine("Total de nombres: " + multiples.Count);
        System.Console.WriteLine("Fet per [El teu nom aquí]");
        Console.WriteLine("Data: " + DateTime.Now.ToString("dd/MM/yyyy"));
    }
}

public static class Metodes
{
    public static List<int> ComptadorMultiples(int limit)
    {
        List<int> result = new List<int>();
        for (int i = 0; i < limit; i++)
        {
            if (i % 7 == 0)
            {
                result.Add(i);
            }
        }
        return result;
    }
}
using System;
using System.Collections.Generic;
using System.Linq;

public class Variables
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class Data
{
    public List<Variables> GetVariables()
    {
        return new List<Variables>
        {
            new Variables { Id = 1, Name = "One" },
            new Variables { Id = 2, Name = "Two" },
            new Variables { Id = 3, Name = "Three" },
            new Variables { Id = 4, Name = "Four" },
            new Variables { Id = 5, Name = "Five" }
        };
    }
}

public class Program
{
    public static void SkipWhileAndTake()
    {
        Data data = new Data();
        var variables = data.GetVariables();

        var result = variables.SkipWhile(v => v.Id < 3).Take(2);

        foreach (var variable in result)
        {
            Console.WriteLine($"Id: {variable.Id}, Name: {variable.Name}");
        }
    }

    public static void SaveTextToFile()
    {
        Console.WriteLine("Sisesta tekst, mida soovid salvestada:");
        string text = Console.ReadLine();

        Console.WriteLine("Sisesta faili asukoht:");
        string filePath = Console.ReadLine();

        try
        {
            System.IO.File.WriteAllText(filePath, text);
            Console.WriteLine("Tekst salvestati edukalt.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Tekkis viga: {ex.Message}");
        }
    }

    public static void NumberPyramid()
    {
        int rows = 5;

        for (int i = 1; i <= rows; i++)
        {
            for (int j = 1; j <= rows - i; j++)
            {
                Console.Write(" ");
            }
            for (int k = 1; k <= i; k++)
            {
                Console.Write($"{k} ");
            }
            Console.WriteLine();
        }
    }

    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Vali meetod:");
            Console.WriteLine("1 - SkipWhile ja Take");
            Console.WriteLine("2 - Teksti salvestamine failile");
            Console.WriteLine("3 - Numbri püramiid");
            Console.WriteLine("4 - Välju");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    SkipWhileAndTake();
                    break;
                case "2":
                    SaveTextToFile();
                    break;
                case "3":
                    NumberPyramid();
                    break;
                case "4":
                    return;
                default:
                    Console.WriteLine("Vale valik, proovi uuesti.");
                    break;
            }
        }
    }
}


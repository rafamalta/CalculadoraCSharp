﻿namespace ProjetoCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"O resultado da soma é {v1 + v2}");

            Console.ReadKey();
        }
    }
}
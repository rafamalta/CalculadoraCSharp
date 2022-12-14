namespace ProjetoCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Divisao();
            //Subtracao();
            //Soma();
        }

        static void Soma()
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

        static void Subtracao()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");

            Console.WriteLine($"O resultado da subtração é {v1 - v2}");

            Console.ReadKey();
        }

        static void Divisao()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            
            Console.WriteLine($"O resultado da divisão é {v1 / v2}");

            Console.ReadKey();
        }
    }
}
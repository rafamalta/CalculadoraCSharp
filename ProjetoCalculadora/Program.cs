namespace ProjetoCalculadora
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Menu()
        {
            Console.Clear();
            
            Console.WriteLine("O que deseja fazer?");
            Console.WriteLine("1 - Soma");
            Console.WriteLine("2 - Subtração");
            Console.WriteLine("3 - Divisão");
            Console.WriteLine("4 - Mulplicação");
            Console.WriteLine("5 - Sair");

            Console.WriteLine("--------------");

            Console.Write("Selecione uma opção: ");

            short opcao = short.Parse(Console.ReadLine());

            switch (opcao)
            {
                case 1: Soma(); break;
                case 2: Subtracao(); break;
                case 3: Divisao(); break;
                case 4: Multiplicacao(); break;
                case 5: System.Environment.Exit(0); break;
                default: Menu(); break;
            }

            Console.ReadKey();
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
            Menu();
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
            Menu();
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
            Menu();
        }

        static void Multiplicacao()
        {
            Console.Clear();

            Console.Write("Primeiro valor: ");
            float v1 = float.Parse(Console.ReadLine());
            Console.Write("Segundo valor: ");
            float v2 = float.Parse(Console.ReadLine());

            Console.WriteLine("");
            
            Console.WriteLine($"O resultado da multiplicação é {v1 * v2}");

            Console.ReadKey();
            Menu();
        }
    }
}
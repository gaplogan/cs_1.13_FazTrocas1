using System;

namespace cs_1._13_FazTrocas1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2, aux;

            Console.Clear();

            do
            {
                Console.Write("Digite o primeiro número: ");
                n1 = int.Parse(Console.ReadLine());

                Console.Write("Digite o segundo número: ");
                n2 = int.Parse(Console.ReadLine());

                Console.WriteLine(); //salta linha

            } while (n1 == n2);

            Console.WriteLine();
            Console.WriteLine("Valores antes das trocas:");
            Console.WriteLine($"Primeiro número {n1}");
            Console.WriteLine($"Segundo número {n2}");

            //{Faz as trocas utilizando uma variável auxiliar}
            aux = n1;
            n1 = n2;
            n2 = aux;

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Valores após das trocas:");
            Console.WriteLine($"Primeiro número {n1}");
            Console.WriteLine($"Segundo número {n2}");
        }
    }
}

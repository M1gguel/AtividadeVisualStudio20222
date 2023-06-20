using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_números_e_calcular
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nota1, nota2, nota3, nota4, total;

            Console.WriteLine("=___________________________=");
            Console.WriteLine("+         Calcular          +");
            Console.WriteLine("+           Média           +");
            Console.WriteLine("=___________________________=");

            Console.Write("Digite o número 1: ");
            nota1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o número 2: ");
            nota2 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o número 3: ");
            nota3 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Digite o número 4: ");
            nota4 = Convert.ToInt32(Console.ReadLine());

            total = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine("A média desses número é: " + total);

            Console.WriteLine("=___________________________=");
            Console.WriteLine("+           Fim             +");
            Console.WriteLine("=___________________________=");
        }
    }
}

using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace caluclo_de_média_se_passou_ou_não
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, nota4, total;

            Console.Write("Digite o número 1: ");
            nota1 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o número 2: ");
            nota2 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o número 3: ");
            nota3 = Convert.ToDouble(Console.ReadLine());

            Console.Write("Digite o número 4: ");
            nota4 = Convert.ToDouble(Console.ReadLine());

            total = (nota1 + nota2 + nota3 + nota4) / 4;
            Console.WriteLine("A média desses número é: " + total);

           if (total >= 7) {
                Console.WriteLine("Você está aprovado, parabèns!!!");
            }
              else {
                Console.WriteLine("Você está reprovado, talvez dê certo na próxima :(");
               }
        }
    }
}

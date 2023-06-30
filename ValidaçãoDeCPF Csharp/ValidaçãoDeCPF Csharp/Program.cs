using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ValidaçãoDeCPF_Csharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int p = { 10, 9, 8, 7, 6, 5, 4, 3, 2 }


            Console.Write("Insira seu CPF: ");
            string cpf = Console.ReadLine();

            int[] numeroInteiro = cpf.Select (numero=> Convert.ToInt32(numero.ToString())).ToArray();
            Console.WriteLine(string.Join(",", numeroInteiro));

            
        }
    }
}

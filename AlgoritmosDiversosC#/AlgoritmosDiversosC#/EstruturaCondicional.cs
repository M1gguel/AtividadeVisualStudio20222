using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosDiversosC_
{
    internal class EstruturaCondicional
    {
        static void Main()
        {
            Console.WriteLine("======== Estrutura condicional ========");

            int nota = 8;

            if (nota >= 7)
            {
                Console.WriteLine("Aluno Aprovado");
            }
            Console.WriteLine("========================================");

            if (nota >= 7)
            {
                Console.WriteLine("Aluno Aprovado");
            }
            else
            {
                Console.WriteLine("Aluno Reprovado");
            }

            Console.WriteLine("========================================");

            if (nota >= 9)
            {
                Console.WriteLine("Aluno nota A");
            }
            else if (nota >= 7)
            {
                Console.WriteLine("Aluno nota B");
            }
            else if (nota >= 5)
            {
                Console.WriteLine("Aluno nota C");
            }
            else if (nota <= 3) 
            {
                Console.WriteLine("Aluno nota D");
            }
            else
            {
                Console.WriteLine("Aluno nota E");
            }
            Console.WriteLine("========================================");

            string cor = "vermelho";

            switch (cor) 
            {
                case "Verde":
                    Console.WriteLine("A cor é verde");
                    break;
                case "Vermelho":
                    Console.WriteLine("A cor é vermelho");
                    break;
                case "Azul":
                    Console.WriteLine("A cor é azul");
                    break;
                default:
                    Console.WriteLine("A cor não foi reconhecida");
                    break;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosDiversosC_
{
    internal class LaçoDeRepeticao
    {
        static void Main()
        {
            Console.WriteLine("======== Laço De Repetição ========");

            int contador = 0;

            while (contador <= 5) 
            {
                Console.WriteLine("O valor do contador é: " + contador);
                contador++;
            }
            Console.WriteLine("====================================");

             contador = 0;

            for (contador = 0; contador < 5; contador++)
            {
                Console.WriteLine("O valor do contador é: " +contador);
            }

            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine("O valor do contador é: "+ i); 
            }
            Console.WriteLine("====================================");
            contador = 0;

            do
            {
                Console.WriteLine("O valor do contador é: " + contador);
                contador++;
            }while (contador <= 5);

            Console.WriteLine("====================================");

            string[] frutas = { "maçã", "banana", "laranja", "tomatate" };

            for (int i = 0;i < frutas.Length;i++)
            {
                Console.WriteLine(frutas[i]);
            }


            Console.WriteLine("====================================");

            foreach (string fruta in frutas)
            { 
                Console.WriteLine(fruta); 
            }
        }
    }
}

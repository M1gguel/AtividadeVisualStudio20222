using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListadeComprasEdson
{
    internal class ListadeCompras
    {
        static public void  ImprimeLista(List <string> ListaDeItens, string Título = "--------------")
        {
            Título = "Cupom Fiscal";
            Console.WriteLine("================= " + Título + "=================");

            foreach (string iten in ListaDeItens) 
            {
                Console.WriteLine(iten);
            }
        }
        static void Main()
        {
            List <string> ListaDeitens = new List<string>();
            ListaDeitens.Add("1 - Arroz = 15.77");
            ListaDeitens.Add("1 - Contra Filé = 45.99");
            ListaDeitens.Add("1 - Batata = 17.47");

            ListaDeitens.Sort();
            ImprimeLista(ListaDeitens);

            Console.WriteLine("==================================================");
            Console.WriteLine("Total:                                         " + Total);
        }
    }
}

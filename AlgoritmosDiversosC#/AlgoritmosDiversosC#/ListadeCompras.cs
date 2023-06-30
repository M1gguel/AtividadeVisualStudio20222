using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmosDiversosC_
{
    internal class ListadeCompras
    {

        static void Main()
        {

            List<string> ListaDeCompras = new List<string>();

            Console.WriteLine(";;;;;;;;;;;; Programa de lista de Compras ;;;;;;;;;;;;");

            while (true)
            {
                Console.WriteLine("Digite um item para adicionar a lista (ou 'parar' para sair): ");
                string item = Console.ReadLine();

                if (item.ToLower() == "parar")
                {
                    break;
                }
                ListaDeCompras.Add(item);
                Console.WriteLine("Item adicionado com sucesso");
            }
            Console.WriteLine("----- Sua lista de compras -----");

            //Imprimir a lista, porém caso esteja vazia, retornar o texto "A Lista está Vazia", 
            //Caso contrário imprimir todos os itens na tela

            if (ListaDeCompras.Count <= 0)
            {
                Console.WriteLine("A Lista está Vazia");
            }
            else
            {
                foreach (string item in ListaDeCompras)
                {
                    Console.WriteLine(item);
                }
            }


        }
    }
}

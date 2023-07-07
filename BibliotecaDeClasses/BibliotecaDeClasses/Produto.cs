using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClasses
{
    public class Produto
    {
        public int Idprodutos = 1;
        public string NomeProduto = "Cumbuca";
        public double Preco = 15.99;
        public int Quantidade = 5;

        public virtual void MostrarDetalhesProduto()
        {
            Console.WriteLine("----------------- Detalhes Do Produto -----------------");
            Console.WriteLine("Id: {0}", Idprodutos);
            Console.WriteLine("Nome Do Produto: {0}", NomeProduto);
            Console.WriteLine("Preço Do Produto: {0}", Preco);
            Console.WriteLine("Quantidade: {0}", Quantidade);
        }

    }
}

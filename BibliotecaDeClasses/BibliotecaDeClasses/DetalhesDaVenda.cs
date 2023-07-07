using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClasses
{
    internal class DetalhesDaVenda : Produto
    {
        public override void MostrarDetalhesProduto()
        {
            Console.WriteLine("--------------------- Nota Fiscal ---------------------");
            base.MostrarDetalhesProduto();
            Console.WriteLine("----------------- Detalhes Do Cliente -----------------");
            Console.WriteLine("Id Cliente: 1");
            Console.WriteLine("Nome Completo: Miguel Perez Silva");
            Console.WriteLine("Telefone: 199552469");
            Console.WriteLine("Endereço Do Cliente: Rua Ipanema n:47");
        }
    }
}

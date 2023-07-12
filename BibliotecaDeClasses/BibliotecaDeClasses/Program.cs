using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Venda venda = new Venda();
            venda.MostrarDetalhesProduto();
        }
    }
}

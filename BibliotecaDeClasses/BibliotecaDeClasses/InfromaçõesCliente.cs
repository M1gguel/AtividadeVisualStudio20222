using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClasses
{
    public abstract class InfromaçõesCliente : Cliente
    {
        public abstract void MostrarDetalhesClientes();
        public void MostrarDetalhesCliente()
        {
            Console.WriteLine("----------------- Detalhes Do Cliente -----------------");
            Console.WriteLine("Nome Completo: {0}", NomeCompleto);
            Console.WriteLine("Email: {0}", Email);
            Console.WriteLine("Telefone: {0}", Telefone);
            Console.WriteLine("Endereço: {0}", Endereco);
            Console.WriteLine("Data De Nascimento: {0}", DataDeNascimento);
        }
    }
}

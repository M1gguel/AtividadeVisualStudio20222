using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BibliotecaDeClasses
{
    internal class Cliente
    {
        protected Cliente() {
       private int IdCliente = 1;
        public string NomeCompleto = "Miguel Perez Silva";
        public string Email = "miguelpsilva0@gmail.com";
        public int Telefone = 199552469;
        private string Senha = "miguelbrabo";
        public string Endereco = "Rua Ipanema n:47";
        public int DataDeNascimento = 04 / 07 / 2005;
    }
        
    }

}
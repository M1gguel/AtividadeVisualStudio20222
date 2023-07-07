using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBiblioteca
{
    internal class Livro
    {
      
        public int id { get; set; }
        public string Título;
        private int ano;
        private int numeroPaginas;

        public int Ano
        {
            get { return ano; }
            set
            {
                if (value > 0)
                {
                    ano = value;
                }
                else
                {
                    Console.WriteLine("Ano de publicação inválido");
                }
            }
        }

        public int Numeropagina
        {
            get { return numeroPaginas; }
            set {
                if (value > 0)
                {
                    numeroPaginas = value;
                }
                else
                {
                    Console.WriteLine("Número de Páginas inválido");
                }
            }
        }

        public virtual void MostrarDetalhes()
        {
            Console.WriteLine("Id: {0}", id);
            Console.WriteLine("Título: {0}", Título);
            Console.WriteLine("Ano: {0}", Ano);
            Console.WriteLine("Número de Página: {0}", numeroPaginas);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoDoObjeto
{
    internal class Livro
    {
         
        public int IdLivro;
        public string Título;
        public string Autor;
        public int NumeroPaginas;
        public double Preco;

        public Livro(int idLivro = 0, string titulo = "", string autor = "", int numeroPaginas = 0, double preco = 0.0)
        {
            IdLivro = idLivro;
            Título = titulo;
            Autor = autor;
            NumeroPaginas = numeroPaginas;
            Preco = preco;  
        }

        public void ImprimirDetalhes()
        {
            Console.WriteLine("------------------------------------------");
            Console.WriteLine("Identificação: {0}", this.IdLivro);
            Console.WriteLine("Título: {0}", this.Título);
            Console.WriteLine("Autor: {0}", this.Autor);
            Console.WriteLine("Número de Páginas: {0}", this.NumeroPaginas);
            Console.WriteLine("Preço: {0:c}", this.Preco);
            Console.WriteLine("------------------------------------------");
        }

    }


}
    


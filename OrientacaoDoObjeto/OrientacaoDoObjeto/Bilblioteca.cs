using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoDoObjeto
{
    internal class Bilblioteca
    {
        public string Nome;
        public List<Livro> catálogo;

        public Bilblioteca() 
        {
            catálogo = new List<Livro>();
        }

        public void CadastrarLivro(Livro livro)
        {
            catálogo.Add(livro);
        }

        public void MostrarCatálogo()
        {
            Console.WriteLine("O Catálogo de Livros da bibilioteca: {0}", Nome);
            Console.WriteLine("==============================================");
            foreach (var Livro in catálogo)
            {
                Console.WriteLine("Identificação: {0} | {1} | Preço: {2:c}", Livro.IdLivro, Livro.Título, Livro.Preco);
            }
            Console.WriteLine("==============================================");
            Console.WriteLine("Total de Livros: {0}", catálogo.Count());
        }
   }
}

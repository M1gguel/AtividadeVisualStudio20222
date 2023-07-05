using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoDoObjeto
{
    internal class AppBiblioteca
    {
        static void Main()
        {
            Bilblioteca biblioteca = new Bilblioteca();
            biblioteca.Nome = "Senac Marília";

            Livro livro = new Livro();
            livro.IdLivro = 1;
            livro.Título = "Os Três Porquinhos E Os Anões";
            livro.Autor = "Justin Bieber E Luan Santana";
            livro.NumeroPaginas = 350;
            livro.Preco = 9.99;

            biblioteca.CadastrarLivro(livro);

            Livro livroPT2 = new Livro();
            livroPT2.IdLivro = 2;
            livroPT2.Título = "Turma Do Bigode E Suas Aventuras";
            livroPT2.Autor = "Justin Bieber, Luan Santana, Naldo Benny E Ariana Grande";
            livroPT2.NumeroPaginas = 550;
            livroPT2.Preco = 12.48;

            biblioteca.CadastrarLivro(livroPT2);
            biblioteca.MostrarCatálogo();
        }
    }
}

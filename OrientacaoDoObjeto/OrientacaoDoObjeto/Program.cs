using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace OrientacaoDoObjeto
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro();

            livro.IdLivro = 1;
            livro.Título = "Os Três Porquinhos E Os Anões";
            livro.Autor = "Justin Bieber E Luan Santana";
            livro.NumeroPaginas = 350;
            livro.Preco = 9.99;

            livro.ImprimirDetalhes();

            Livro livroPT2 = new Livro();

            livroPT2.IdLivro = 2;
            livroPT2.Título = "Turma Do Bigode E Suas Aventuras";
            livroPT2.Autor = "Justin Bieber, Luan Santana, Naldo Benny E Ariana Grande";
            livroPT2.NumeroPaginas = 550;
            livroPT2.Preco = 12.48;

            Console.WriteLine("Informações Do Livro PT:2");

            livroPT2.ImprimirDetalhes();

            Console.WriteLine("Informações Do Livro PT: 3");

            Livro livroPT3 = new Livro(3,"Mutantes E Curupira", "Justin Bieber, Luan Santana E Neymar", 350, 7.51);

            Livro livroPT4 = new Livro(4, numeroPaginas: 20, titulo: "O Varão E A Varoa", autor: "Tiaguinho E Pelé");

            livroPT3.ImprimirDetalhes();

            Console.WriteLine("Informações Do Livro PT: 4");

            livroPT4.ImprimirDetalhes();

            Livro livroPT5 = new Livro()
            {
                IdLivro = 5,
                Título = "Farinha Na Cumbuca",
                Autor = "Juliette E Tirulipa",
                NumeroPaginas = 150,
                Preco = 15.12
            };
        }
    }
}

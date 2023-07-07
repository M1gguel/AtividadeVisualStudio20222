using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppBiblioteca
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Livro livro = new Livro();
            livro.id = 1;
            livro.Título = "A Pequena Sereia";
            livro.Ano = 1457;
            livro.Numeropagina = 247;

            livro.MostrarDetalhes();

            Console.WriteLine("-----------------------------------");

            LivroDigital livroDigital = new LivroDigital();

            livroDigital.id = 2;
            livroDigital.Título = "As Aventuras De Belinha";
            livroDigital.Ano = 1748;
            livroDigital.Numeropagina = 187;
            livroDigital.TamanhoMB = 256;
            livroDigital.tipoArquivo = "PDF";

            livroDigital.MostrarDetalhes();
        }
    }
}

﻿using System;
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
        }
    }
}

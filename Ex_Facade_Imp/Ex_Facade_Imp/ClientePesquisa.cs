using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Facade_Imp
{
    internal interface ClientePesquisa
    {
        Livro PesquisaLivro(int isbn);
    }
}

using Ex_Facade_Imp.Subsistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Facade_Imp
{
    internal class ClienteServicoB
    {
        ServicoB servico;

        public ClienteServicoB()
        {
            servico = new ServicoB();
        }

        public List<Livro> PesquisaLivro(int isbn)
        {
            List<Livro> livros = new List<Livro>();

            List<Livro> livrosResponse = servico.GetLivro(isbn);

            foreach (Livro item in livrosResponse)
            {
                livros.Add(item);
            }

            return livros;
        }
    }
}

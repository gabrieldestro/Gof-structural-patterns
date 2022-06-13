using Ex_Facade_Imp.Subsistemas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Facade_Imp
{
    public class ClienteServicoA
    {
        ServicoA servico;

        public ClienteServicoA()
        {
            servico = new ServicoA();
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

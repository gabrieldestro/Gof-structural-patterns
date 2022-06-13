using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Facade_Imp
{
    public class CompararPreco
    {
        ClienteServicoA servicoA;
        ClienteServicoB servicoB;

        public CompararPreco()
        {
            servicoB = new ClienteServicoB();
            servicoA = new ClienteServicoA();
        }

        public void Comparar(int isbn) 
        { 
            StringBuilder sb = new StringBuilder();
            List<Livro> livrosAgregados = new List<Livro>();

            sb.Append($"Pesquisando livros a venda com ISBN {isbn}!\n");

            livrosAgregados.AddRange(servicoA.PesquisaLivro(isbn));
            livrosAgregados.AddRange(servicoB.PesquisaLivro(isbn));

            if (livrosAgregados.Count == 0)
            {
                sb.Append($"Nenhum livro a venda encontrado com ISBN {isbn}!\n");
            }
            else 
            {
                foreach (Livro livro in livrosAgregados.OrderBy(x => x.Preco).ToList())
                {
                    sb.Append($"Preço {livro.Preco}, na livraria {livro.Origem}. Livro {isbn}-{livro.Titulo}, de {livro.Autor}.\n");
                }
            }
            
            Console.WriteLine(sb.ToString());
        }
    }
}

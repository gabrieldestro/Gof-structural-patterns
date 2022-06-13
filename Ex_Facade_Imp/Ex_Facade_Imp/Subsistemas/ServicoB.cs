using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Facade_Imp.Subsistemas
{
    public sealed class ServicoB
    {
        // Considerando que o Servico usa um modelo analogo apenas para facilitar a implementacao,
        // obviamente o servico nao teria uma referencia a minha model de livro
        List<Livro> livros = new List<Livro>();

        public ServicoB()
        {
            livros.Add(new Livro() { id = 1, ISBN = 1, Titulo = "LivroA", Autor = "AutorA", Preco = 15.00M, Origem = "LivrariaC" });
            livros.Add(new Livro() { id = 2, ISBN = 2, Titulo = "LivroA1", Autor = "AutorA", Preco = 10.00M, Origem = "LivrariaC" });
            livros.Add(new Livro() { id = 3, ISBN = 2, Titulo = "LivroA1", Autor = "AutorA", Preco = 8.00M, Origem = "LivrariaB" });
            livros.Add(new Livro() { id = 4, ISBN = 5, Titulo = "LivroD", Autor = "AutorD", Preco = 10.00M, Origem = "LivrariaB" });
            livros.Add(new Livro() { id = 5, ISBN = 6, Titulo = "LivroE", Autor = "AutorE", Preco = 12.00M, Origem = "LivrariaA" });
        }

        public List<Livro> GetLivro(int isbn)
        {
            return livros.FindAll(x => x.ISBN == isbn).ToList();
        }
    }
}

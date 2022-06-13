using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Facade_Imp
{
    public class Livro
    {
        public int id { get; set; }
        public int ISBN { get; set; }
        public string Titulo { get; set; }
        public string Autor { get; set; }
        public decimal Preco { get; set; }
        public string Origem { get; set; }
    }
}

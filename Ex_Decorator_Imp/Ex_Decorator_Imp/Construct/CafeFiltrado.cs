using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Decorator_Imp.Construct
{
    public class CafeFiltrado : CafeBase
    {
        public CafeFiltrado() : base("Café Filtrado", 5.00M)
        {
        }

        public override void Descrever()
        {
            Console.WriteLine($"{Descricao}");
        }
    }
}

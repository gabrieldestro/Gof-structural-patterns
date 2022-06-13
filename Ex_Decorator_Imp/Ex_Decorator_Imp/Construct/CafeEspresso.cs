using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Decorator_Imp.Construct
{
    public class CafeEspresso : CafeBase
    {
        public CafeEspresso() : base("Café Espresso", 10.00M)
        {
        }

        public override void Descrever()
        {
            Console.WriteLine($"{Descricao}");
        }
    }
}

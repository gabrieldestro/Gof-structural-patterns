using Ex_Decorator_Imp.Construct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Decorator_Imp.Decorator
{
    internal class LeiteDecorator : OpcionalDecorator
    {
        public LeiteDecorator(CafeBase _CafeBase) : base($"com adicional de leite.", 2.00M, _CafeBase)
        {
        }

        public override void Descrever()
        {
            CafeBase.Descrever();
            Console.WriteLine($"    {Descricao}");
        }

    }
}

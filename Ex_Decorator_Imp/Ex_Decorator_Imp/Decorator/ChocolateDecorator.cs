using Ex_Decorator_Imp.Construct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Decorator_Imp.Decorator
{
    internal class ChocolateDecorator : OpcionalDecorator
    {
        public ChocolateDecorator(CafeBase _CafeBase) : base("com adicional de chocolate.", 5.00M, _CafeBase)
        {
        }

        public override void Descrever()
        {
            CafeBase.Descrever();
            Console.WriteLine($"    {Descricao}");
        }

    }
}

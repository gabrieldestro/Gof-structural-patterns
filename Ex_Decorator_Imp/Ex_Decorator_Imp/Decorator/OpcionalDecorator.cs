using Ex_Decorator_Imp.Construct;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Decorator_Imp.Decorator
{
    public abstract class OpcionalDecorator : CafeBase
    {
        protected CafeBase CafeBase { get; set; }

        protected OpcionalDecorator(string _Descricao, decimal _Preco, CafeBase _CafeBase) : base(_Descricao, _Preco)
        {
            CafeBase = _CafeBase;
            Preco = CafeBase.GetPreco() + _Preco;
        }
    }
}

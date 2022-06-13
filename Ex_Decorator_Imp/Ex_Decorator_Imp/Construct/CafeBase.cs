using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Decorator_Imp.Construct
{
    public abstract class CafeBase
    {
        protected string Descricao;
        protected decimal Preco;

        public CafeBase(string _Descricao, decimal _Preco)
        {
            Descricao = _Descricao;
            Preco = _Preco;
        }

        public abstract void Descrever();

        public decimal GetPreco() 
        {
            return Preco;
        }

        public void ExibirPreco() 
        {
            Console.WriteLine($"Preço: {Preco}");
        }
    }
}

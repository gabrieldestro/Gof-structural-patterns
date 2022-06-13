using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Adapter_Imp.Adaptee
{
    public sealed class SuperGeradorGrafico
    {
        public void Init() { 
        }

        public void DesenharGrafico(string titulo, List<string> x, List<int> y)
        {
            Console.WriteLine("Gerar gráfico usando super gerador gráfico.");
        }
    }
}

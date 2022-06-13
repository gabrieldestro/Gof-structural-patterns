using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Adapter_Imp.Adapter
{
    public interface IGrafico
    {
        string Titulo { get; set; }
        List<string> ListaX { get; set; }
        List<int> ListaY { get; set; }

        void GerarGrafico();
    }
}

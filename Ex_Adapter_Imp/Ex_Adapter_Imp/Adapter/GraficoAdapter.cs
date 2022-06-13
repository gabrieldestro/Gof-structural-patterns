using Ex_Adapter_Imp.Adaptee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Adapter_Imp.Adapter
{
    public class GraficoAdapter : IGrafico
    {
        public string Titulo { get; set; }
        public List<string> ListaX { get; set; }
        public List<int> ListaY { get; set; }

        SuperGeradorGrafico SuperGeradorGrafico { get; set; }

        public GraficoAdapter(string _Titulo, List<string> _ListaX, List<int> _ListaY)
        {
            SuperGeradorGrafico = new SuperGeradorGrafico();
            SuperGeradorGrafico.Init();

            Titulo = _Titulo;
            ListaX = _ListaX;
            ListaY = _ListaY;
        }

        public void GerarGrafico()
        {
            SuperGeradorGrafico.DesenharGrafico(Titulo, ListaX, ListaY);
        }
    }
}

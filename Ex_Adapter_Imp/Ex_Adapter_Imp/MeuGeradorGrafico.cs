using Ex_Adapter_Imp.Adapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Adapter_Imp
{
    public class MeuGeradorGrafico : IGrafico
    {
        public string Titulo { get; set; }
        public List<string> ListaX { get; set; }
        public List<int> ListaY { get; set; }

        public MeuGeradorGrafico(string _Titulo, List<string> _ListaX, List<int> _ListaY)
        {
            Titulo = _Titulo;
            ListaX = _ListaX;
            ListaY = _ListaY;   
        }

        public void GerarGrafico() 
        {
            Console.WriteLine("Gerar gráfico usando meu gerador grafico antigo.");
        }
    }
}

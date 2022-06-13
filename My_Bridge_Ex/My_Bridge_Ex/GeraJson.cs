using Domain.My_Bridge_Ex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Bridge_Ex
{
    public class GeraJson : IGeraArquivo
    {
        string nomeArquivo;

        public GeraJson(string _nomeArquivo)
        {
            nomeArquivo = _nomeArquivo;
        }

        public void GravaArquivo(Funcionario conteudo)
        {
            Console.WriteLine($"Gerando arquivo json de nome {nomeArquivo} - {conteudo.ToString()}");
        }
    }
}

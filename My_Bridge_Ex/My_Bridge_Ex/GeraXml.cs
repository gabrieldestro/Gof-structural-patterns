using Domain.My_Bridge_Ex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Bridge_Ex
{
    public class GeraXml : IGeraArquivo
    {
        string nomeArquivo;

        public GeraXml(string _nomeArquivo)
        {
            nomeArquivo = _nomeArquivo;
        }

        public void GravaArquivo(Funcionario conteudo)
        {
            Console.WriteLine($"Gerando arquivo xml de nome {nomeArquivo} - {conteudo.ToString()}");
        }
    }
}

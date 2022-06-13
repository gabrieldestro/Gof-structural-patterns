using Domain.My_Bridge_Ex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Bridge_Ex
{
    public abstract class Arquivo
    {
        protected IGeraArquivo gerador;

        public Arquivo(IGeraArquivo _gerador)
        {
            gerador = _gerador;
        }

        public void GravaArquivo(Funcionario func)
        {
            gerador.GravaArquivo(func);
        }
    }
}

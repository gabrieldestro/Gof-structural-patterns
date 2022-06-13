using Domain.My_Bridge_Ex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Bridge_Ex
{
    public interface IGeraArquivo
    {
        public void GravaArquivo(Funcionario conteudo);
    }
}

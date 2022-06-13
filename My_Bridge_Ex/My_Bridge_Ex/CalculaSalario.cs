using Domain.My_Bridge_Ex;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace My_Bridge_Ex
{
    public class CalculaSalario : Arquivo
    {
        public CalculaSalario(IGeraArquivo _gerador) : base(_gerador) 
        {
        }

        public void ProcessaSalarioFuncionario(Funcionario func)
        {
            func.salarioTotal = func.salarioBase + func.incentivo;
            Console.WriteLine($"O Salario total de {func.nome} é {func.salarioTotal}");

            gerador.GravaArquivo(func);
        }
    }
}

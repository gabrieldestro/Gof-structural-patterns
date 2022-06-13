using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Composite_Imp
{
    public class Questao : ItemQuestionario
    {
        public Questao(string desc) : base(desc)
        {
        }

        public override void Exibir()
        {
            Console.WriteLine($"    Questão: {Descricao}");
        }
    }
}

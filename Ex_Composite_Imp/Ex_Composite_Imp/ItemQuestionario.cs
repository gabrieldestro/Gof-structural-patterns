using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Composite_Imp
{
    public abstract class ItemQuestionario
    {
        public string Descricao { get; set; }

        public ItemQuestionario(string desc)
        {
            Descricao = desc;
        }

        public virtual void Add() 
        { 
        }
        public virtual void Remove()
        {
        }

        public abstract void Exibir();
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Composite_Imp
{
    public class Grupo : ItemQuestionario
    {
        List<ItemQuestionario> items = new List<ItemQuestionario>();

        public Grupo(string desc) : base(desc)
        {
        }

        public void Add(ItemQuestionario item) 
        {
            items.Add(item);
        }

        public void Remove(ItemQuestionario item)
        {
            try
            {
                items.Remove(item);
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine($"Não foi possível remover o item: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Não foi possível remover o item: {item?.Descricao}. {ex.Message}");
            }
        }

        public override void Exibir()
        {
            Console.WriteLine($"Grupo: {Descricao}");

            foreach (var item in items)
            {
                item.Exibir();
            }
        }
    }
}

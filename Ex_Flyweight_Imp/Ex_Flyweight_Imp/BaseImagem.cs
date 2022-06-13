using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Flyweight_Imp
{
    public abstract class BaseImagem
    {
        public BaseImagem(string Imagem, int altura, int largura)
        {
            this.largura = largura;
            this.altura = altura;
            this.Imagem = Imagem;
        }

        // variaveis instrecas
        private int largura { get; set; }
        private int altura { get; set; }
        private string Imagem { get; set; }

        // variaveis extrinsecas
        public int posX { get; set; }
        public int posY { get; set; }

        public void MostrarImagem() 
        {
            Console.WriteLine($"Imagem: {Imagem} - ({largura} x {altura}). Coordenadas: ({posX},{posY})");
        }
    }
}

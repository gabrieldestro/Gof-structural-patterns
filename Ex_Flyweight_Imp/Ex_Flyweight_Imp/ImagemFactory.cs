using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex_Flyweight_Imp
{
    internal class ImagemFactory
    {
        public Dictionary<string, BaseImagem> BaseImagens = new Dictionary<string, BaseImagem>();

        public BaseImagem? ObtemImagem(string imagem) 
        {
            BaseImagem? imgObj = null;

            if (BaseImagens.ContainsKey(imagem))
            {
                Console.WriteLine($"Reaproveitando objeto: {imagem}");
                imgObj = BaseImagens[imagem];
            }
            else 
            {
                if (imagem == "ImagemA")
                {
                    Console.WriteLine($"Criando novo objeto: {imagem}");

                    var imagemA = new ImagemA();
                    BaseImagens.Add("ImagemA", imagemA);
                    imgObj = imagemA;
                }
                else if (imagem == "ImagemB")
                {
                    Console.WriteLine($"Criando novo objeto: {imagem}");

                    var imagemB = new ImagemB();
                    BaseImagens.Add("ImagemB", imagemB);
                    imgObj = imagemB;
                }
                else
                {
                    Console.WriteLine("Imagem não existe!");
                }
            }

            return imgObj;
        }
    }
}

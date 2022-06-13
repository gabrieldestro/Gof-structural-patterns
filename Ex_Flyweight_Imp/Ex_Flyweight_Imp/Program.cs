// See https://aka.ms/new-console-template for more information
using Ex_Flyweight_Imp;

try
{
    ImagemFactory factory = new ImagemFactory();
    BaseImagem imagemA1 = null;
    BaseImagem imagemA2 = null;

    BaseImagem imagemB1 = null;
    BaseImagem imagemB2 = null;

    BaseImagem imagemC = null;

    imagemA1 = factory.ObtemImagem("ImagemA");
    if (imagemA1 != null) 
    {
        imagemA1.posX = 100;
        imagemA1.posY = 50;
        imagemA1.MostrarImagem();

    }

    imagemA2 = factory.ObtemImagem("ImagemA");
    if (imagemA2 != null)
    {
        imagemA2.posX = 10;
        imagemA2.posY = 5;
        imagemA2.MostrarImagem();
    }

    imagemB1 = factory.ObtemImagem("ImagemB");
    if (imagemB1 != null)
    {
        imagemB1.posX = 1200;
        imagemB1.posY = 500;
        imagemB1.MostrarImagem();
    }

    imagemB2 = factory.ObtemImagem("ImagemB");
    if (imagemB2 != null)
    {
        imagemB2.posX = 7100;
        imagemB2.posY = 150;
        imagemB2.MostrarImagem();
    }

    imagemC = factory.ObtemImagem("ImagemC");
    if (imagemC != null)
    {
        imagemC.posX = 120;
        imagemC.posY = 0;
        imagemC.MostrarImagem();
    }

}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}
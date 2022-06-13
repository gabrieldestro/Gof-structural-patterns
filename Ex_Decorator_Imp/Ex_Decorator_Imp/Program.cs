// See https://aka.ms/new-console-template for more information
using Ex_Decorator_Imp.Construct;
using Ex_Decorator_Imp.Decorator;

Console.WriteLine("Menu:");
Console.WriteLine("-----");

CafeBase cafeFiltrado = new CafeFiltrado();
cafeFiltrado.Descrever();
cafeFiltrado.ExibirPreco();

Console.WriteLine("-----");

CafeBase cafeEspresso = new CafeEspresso();
cafeEspresso.Descrever();
cafeEspresso.ExibirPreco();

Console.WriteLine("-----");

OpcionalDecorator cafeEspressoComChocolate = new ChocolateDecorator(new CafeEspresso());
cafeEspressoComChocolate.Descrever();
cafeEspressoComChocolate.ExibirPreco();

Console.WriteLine("-----");

OpcionalDecorator cafeEspressoComLeite = new LeiteDecorator(new CafeEspresso());
cafeEspressoComLeite.Descrever();
cafeEspressoComLeite.ExibirPreco();

Console.WriteLine("-----");

OpcionalDecorator cafeFiltradoComLeiteEChocolate = new LeiteDecorator(new ChocolateDecorator(new CafeFiltrado()));
cafeFiltradoComLeiteEChocolate.Descrever();
cafeFiltradoComLeiteEChocolate.ExibirPreco();

Console.WriteLine("-----");

OpcionalDecorator cafeEspressoComLeiteEChocolate = new LeiteDecorator(new ChocolateDecorator(new CafeEspresso()));
cafeEspressoComLeiteEChocolate.Descrever();
cafeEspressoComLeiteEChocolate.ExibirPreco();

Console.WriteLine("-----");

OpcionalDecorator cafeEspressoComLeiteEmDobro = new LeiteDecorator(new LeiteDecorator(new CafeEspresso()));
cafeEspressoComLeiteEmDobro.Descrever();
cafeEspressoComLeiteEmDobro.ExibirPreco();
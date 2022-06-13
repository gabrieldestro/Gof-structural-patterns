// See https://aka.ms/new-console-template for more information
using Ex_Adapter_Imp;
using Ex_Adapter_Imp.Adapter;

IGrafico? grafico = null;

Console.WriteLine("Grafico Antigo:");
grafico = new MeuGeradorGrafico(
    "graph", new List<string>() { "a", "b"}, new List<int>() { 1, 2 });
grafico.GerarGrafico();

Console.WriteLine("\n");
Console.WriteLine("Grafico Novo:");
grafico = new GraficoAdapter(
    "graph", new List<string>() { "a", "b" }, new List<int>() { 1, 2 });
grafico.GerarGrafico();

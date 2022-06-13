// See https://aka.ms/new-console-template for more information
using Ex_Proxy_Imp;

Console.WriteLine("Acessar a internet pelo computador da escola:");

IAcessoInternet acessoInternetProxy = new ControladorAcessoInternet();

acessoInternetProxy.AcessarPagina("https://paginanaopermitida.com");
acessoInternetProxy.AcessarPagina("https://portaldoaluno.com");
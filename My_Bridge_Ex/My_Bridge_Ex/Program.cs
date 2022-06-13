// See https://aka.ms/new-console-template for more information
using Domain.My_Bridge_Ex;
using My_Bridge_Ex;

Console.WriteLine("Calcula salario:");

var func = new Funcionario();
func.nome = "João";
func.id = 1;
func.incentivo = 100.00;
func.salarioBase = 1000.00;

Console.WriteLine("Gerando Json");
var calculaSalarioJson = new CalculaSalario(new GeraJson("salario.json"));
calculaSalarioJson.ProcessaSalarioFuncionario(func);

Console.WriteLine("Gerando Xml");
var calculaSalarioXml = new CalculaSalario(new GeraXml("salario.xml"));
calculaSalarioXml.ProcessaSalarioFuncionario(func);

Console.ReadLine();

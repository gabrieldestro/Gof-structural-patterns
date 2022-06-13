// See https://aka.ms/new-console-template for more information
using Ex_Composite_Imp;

Console.WriteLine("Responda as Questões:");

#region criaProva
Grupo prova = new Grupo("Prova");

Grupo portugues = new Grupo("Português");

Grupo gramatica = new Grupo("Gramática");
gramatica.Add(new Questao("Questão 1 de gramática"));
gramatica.Add(new Questao("Questão 2 de gramática"));
portugues.Add(gramatica);

Grupo matematica = new Grupo("Matemática");

Grupo geometria = new Grupo("Geometria");
Grupo geometriaEuclid = new Grupo("Geometria Euclidiana");
geometriaEuclid.Add(new Questao("Questão 1 de Geometria Euclidiana"));
Grupo geometriaNaoEuclid = new Grupo("Geometria Não Euclidiana");
geometriaNaoEuclid.Add(new Questao("Questão 1 de Geometria Não Euclidiana"));
geometria.Add(geometriaEuclid);
geometria.Add(geometriaNaoEuclid);
matematica.Add(geometria);

Grupo algebra = new Grupo("Algebra");
algebra.Add(new Questao("Questão 1 de Algebra"));
algebra.Add(new Questao("Questão 2 de Algebra"));
matematica.Add(algebra);

prova.Add(portugues);
prova.Add(matematica);
#endregion 

Console.WriteLine("---------");
prova.Exibir();
Console.WriteLine("---------");

prova.Remove(portugues);

Console.WriteLine("Prova com alteracoes:");
Console.WriteLine("---------");
prova.Exibir();
Console.WriteLine("---------");

Console.ReadKey();

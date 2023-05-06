// See https://aka.ms/new-console-template for more information
using Strategy.Controller;
using Strategy.Models;
using Strategy.Service.Calculo;

Orcamento reforma = new Orcamento(500);
Console.WriteLine(reforma.Valor);
reforma.ApicaDescontoExtra();
Console.WriteLine(reforma.Valor);

reforma.Aprova();

reforma.ApicaDescontoExtra();
Console.WriteLine(reforma.Valor);

reforma.Finaliza();


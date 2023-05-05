// See https://aka.ms/new-console-template for more information
using Strategy.Service.Calculo;
using Strategy.Controller;
using Strategy.Models;

Console.WriteLine("Hello, World!");

CalculoDeImposto calculador = new CalculoDeImposto();
Orcamento orcamento = new Orcamento(500.0);
orcamento.Itens.Add(new Item("mouse", 250));
orcamento.Itens.Add(new Item("teclado", 250));
orcamento.Itens.Add(new Item("monitor", 250));

calculador.Calcula(orcamento, new ISS());

calculador.Calcula(orcamento, new ICMS());








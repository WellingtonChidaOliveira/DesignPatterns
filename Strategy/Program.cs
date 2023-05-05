// See https://aka.ms/new-console-template for more information
using Strategy.Controller;
using Strategy.Models;
using Strategy.Service.Calculo;

Console.WriteLine("Hello, World!");
CalculoDeImposto calculador = new CalculoDeImposto();
Orcamento orcamento = new Orcamento(500.0);

calculador.Calcula(orcamento, new ISS());

calculador.Calcula(orcamento, new ICMS());
// See https://aka.ms/new-console-template for more information
using Strategy.Controller;
using Strategy.Models;
using Strategy.Service.Calculo;

Console.WriteLine("Hello, World!");
CalculoDeImposto calculador = new CalculoDeImposto();
Orcamento orcamento = new Orcamento(500.0);

calculador.Calcula(orcamento, new ISS(new ICMS()));

calculador.Calcula(orcamento, new ICMS(new ISS()));

calculador.Calcula(orcamento, new ImpostoMuitoAlto(new ISS()));


Console.WriteLine($"ICPP");
calculador.Calcula(orcamento, new ICPP(new IKCV()));
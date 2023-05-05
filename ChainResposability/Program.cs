// See https://aka.ms/new-console-template for more information
using ChainResposability.Controller;
using ChainResposability.Models;

Console.WriteLine("Hello, World!");

CalculadorDeDescontos calculador = new CalculadorDeDescontos();
Orcamento orcamento = new Orcamento(500.0);
orcamento.Itens.Add(new Item("mouse", 250));
orcamento.Itens.Add(new Item("teclado", 250));
orcamento.Itens.Add(new Item("monitor", 250));

double desconto = calculador.Calcula(orcamento);
Console.WriteLine(desconto);
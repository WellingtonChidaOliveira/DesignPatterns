// See https://aka.ms/new-console-template for more information
using TemplatesMethod.Controller;
using TemplatesMethod.Models;
using TemplatesMethod.Reports;

Console.WriteLine("Hello, World!");

ExibeReport exibeReport = new ExibeReport();
var conta = new Conta(nome: "Joao", nomeDoBanco: "BB", telefone: "999999", endereco: "Rua dos Bagres", email: "joao@gmail.com");

exibeReport.Exibe(conta);



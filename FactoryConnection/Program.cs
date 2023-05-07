// See https://aka.ms/new-console-template for more information
using FactoryConnection.Repositories;
using System.Data;

Console.WriteLine("Hello, World!");

IDbConnection connection = new ConnectionFactory().GetConnection();
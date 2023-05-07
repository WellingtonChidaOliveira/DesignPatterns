// See https://aka.ms/new-console-template for more information
using Strategy.Builder;
using Strategy.Service.Desconstos;
using Strategy.Service.Email;
using Strategy.Service.Repositorie;

NotaFiscalBuilder builder = new NotaFiscalBuilder();
builder.AdicionaAcao(new EnviaPorEmail());
builder.AdicionaAcao(new NotaFiscalDao());
builder.AdicionaAcao(new Multiplicador(2));

builder.RazaoSocialNotaFiscal("").
    CnpjNotaFiscal("").
    ItemNotaFiscal(new ItemDaNotaBuilder().NomeItemDaNota("").ValorItemDaNota(0).CreatorItemDaNota()).
    ObservacoesNotaFiscal("").
    DataDeEmissaoNotaFiscal(DateTime.Now).
    Creator();

Console.WriteLine(builder.Itens);

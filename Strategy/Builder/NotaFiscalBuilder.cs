using Strategy.Models;

namespace Strategy.Builder
{
    public class NotaFiscalBuilder
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }

        private double ValorBruto { get; set; }

        private double Imposto { get; set; }

        private DateTime DataDeEmissao { get; set; }
        private string Observacoes { get; set; }

        public List<ItemDaNota> Itens { get; set; }


        public NotaFiscal Creator()
        {
            return new NotaFiscal(RazaoSocial, Cnpj, ValorBruto, Imposto, DataDeEmissao, Observacoes, Itens);
        }

        public NotaFiscalBuilder RazaoSocialNotaFiscal(string razaoSocial)
        {
            this.RazaoSocial = razaoSocial;
            return this;
        }
        public NotaFiscalBuilder CnpjNotaFiscal(string cnpj)
        {
            this.Cnpj = cnpj;
            return this;
        }
        public NotaFiscalBuilder ItemNotaFiscal(ItemDaNota item)
        {
            Itens.Add(item);
            ValorBruto += item.Valor;
            Imposto += item.Valor * 0.05;
            return this;
        }

        public NotaFiscalBuilder ObservacoesNotaFiscal(string observacoes)
        {
            this.Observacoes = observacoes;
            return this;
        }
        public NotaFiscalBuilder DataDeEmissaoNotaFiscal(DateTime dataDeEmissao)
        {
            this.DataDeEmissao = dataDeEmissao;
            return this;
        }

    }
}

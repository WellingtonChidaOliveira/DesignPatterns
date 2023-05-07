namespace Strategy.Models
{
    public class NotaFiscal
    {
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }

        public double ValorBruto { get; set; }

        private double Imposto { get; set; }

        private DateTime DataDeEmissao { get; set; }
        private string Observacoes { get; set; }

        public List<ItemDaNota> Itens { get; set; }

        public NotaFiscal(string razaoSocial, string cnpj, double valorBruto, double imposto, DateTime dataDeEmissao, string observacoes, List<ItemDaNota> itens)
        {
            RazaoSocial = razaoSocial;
            Cnpj = cnpj;
            ValorBruto = valorBruto;
            Imposto = imposto;
            DataDeEmissao = dataDeEmissao;
            Observacoes = observacoes;
            Itens = itens;
        }

    }
}

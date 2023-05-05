namespace ChainResposability.Models.Interfaces
{
    public interface IDesconto
    {
        double Desconto(Orcamento orcamento);

        IDesconto Proximo { get; set; }
    }
}

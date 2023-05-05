using ChainResposability.Models;
using ChainResposability.Models.Interfaces;

namespace ChainResposability.Service.Descontos
{
    public class DescontoMaisDeQuinhentosReais : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconto(Orcamento orcamento)
        {
            if (orcamento.Valor > 500)
            {
                return orcamento.Valor * 0.07;
            }
            return Proximo.Desconto(orcamento);
        }
    }
}

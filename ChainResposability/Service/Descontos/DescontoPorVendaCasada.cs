using ChainResposability.Models;
using ChainResposability.Models.Interfaces;

namespace ChainResposability.Service.Descontos
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get ; set ; }

        public double Desconto(Orcamento orcamento)
        {
            if (Existe(orcamento.Itens))
            {
                return orcamento.Valor * 0.05;
            }
            else
            {
                return Proximo.Desconto(orcamento);
            }
        }

        public bool Existe(IList<Item> item)
        {
            var value = item.Where(x => x.Nome == "LAPIS" && x.Nome == "CANETA").FirstOrDefault();
            return value != null ? true : false;
        }
    }
}

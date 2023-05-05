using ChainResposability.Models;
using ChainResposability.Models.Interfaces;

namespace ChainResposability.Service.Descontos
{
    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get; set; }

        public double Desconto(Orcamento orcamento)
        {
            return 0;
        }
    }
}

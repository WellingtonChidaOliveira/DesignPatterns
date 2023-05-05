using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.ChainResposability.Models;
using DesignPatterns.ChainResposability.Models.Interface;

namespace DesignPatterns
{
    public class DescontoPorCincoItens : IDesconto
    {
        public IDesconto Proximo { get; set; }
        public double Desconto(OrcamentoErase orcamento)
        {
            if (orcamento.Itens.Count > 5)
            {
                return orcamento.Valor * 0.1;
            }
            return Proximo.Desconto(orcamento);
        }
    }
}

﻿using ChainResposability.Models;
using ChainResposability.Models.Interfaces;

namespace ChainResposability.Service.Descontos
{
    public class DescontoPorCincoItens : IDesconto
    {
        public IDesconto Proximo { get ; set; }

        public double Desconto(Orcamento orcamento)
        {
            if (orcamento.Itens.Count > 5)
            {
                return orcamento.Valor * 0.1;
            }
            return Proximo.Desconto(orcamento);
        }
    }
}

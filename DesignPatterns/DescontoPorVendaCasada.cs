using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.ChainResposability.Models;
using DesignPatterns.ChainResposability.Models.Interface;
using DesignPatterns.Strategy.Models;

namespace DesignPatterns
{
    public class DescontoPorVendaCasada : IDesconto
    {
        public IDesconto Proximo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double Desconto(OrcamentoErase orcamento)
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


        public bool Existe(IList<Imposto> item)
        {
            var value = item.Where(x => x.Nome == "LAPIS" && x.Nome == "CANETA").FirstOrDefault();
            return value != null ? true : false;
        }
    }
}

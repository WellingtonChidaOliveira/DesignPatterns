using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.ChainResposability.Models;
using DesignPatterns.ChainResposability.Models.Interface;

namespace DesignPatterns.ChainResposability
{
    public class CalculadorDeDescontos
    {
        public double Calcula(OrcamentoErase orcamento)
        {
            IDesconto desc = new DescontoPorCincoItens();
            IDesconto desc2 = new DescontoMaisDeQuinhentosReais();
            IDesconto desc3 = new SemDesconto();


            desc.Proximo = desc2;
            desc2.Proximo = desc3;

            return desc.Desconto(orcamento);
        }
    }
}

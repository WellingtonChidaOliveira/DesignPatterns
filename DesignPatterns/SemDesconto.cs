using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DesignPatterns.ChainResposability.Models;
using DesignPatterns.ChainResposability.Models.Interface;

namespace DesignPatterns
{
    public class SemDesconto : IDesconto
    {
        public IDesconto Proximo { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public double Desconto(OrcamentoErase orcamento)
        {
            return 0;
        }
    }
}

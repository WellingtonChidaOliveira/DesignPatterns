using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.ChainResposability.Models.Interface
{
    public interface IDesconto
    {

        double Desconto(OrcamentoErase orcamento);

        IDesconto Proximo { get; set; }
    }
}

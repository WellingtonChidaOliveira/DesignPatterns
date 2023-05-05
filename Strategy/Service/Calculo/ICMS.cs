using Strategy.Models;
using Strategy.Models.Interfacer;

namespace Strategy.Service.Calculo
{
    public class ICMS : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.1;
        }
    }
}

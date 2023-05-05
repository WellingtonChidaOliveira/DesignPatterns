using Strategy.Models;
using Strategy.Models.Interfacer;

namespace Strategy.Service.Calculo
{
    public class ISS: IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }
    }
}

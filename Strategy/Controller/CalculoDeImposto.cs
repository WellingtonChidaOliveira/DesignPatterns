using Strategy.Models;
using Strategy.Models.Interfacer;

namespace Strategy.Controller
{
    public class CalculoDeImposto
    {

        public void Calcula(Orcamento orcamento, IImposto imposto)
        {
            double calculo = imposto.Calcula(orcamento);
            Console.WriteLine(calculo);
        }
    }
}

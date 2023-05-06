using Strategy.Models;
using Strategy.Models.Interfacer;
using Strategy.Models.Template;

namespace Strategy.Service.Calculo
{
    internal class ICPP : TemplateDeImpostoCondicional
    {

        //Template Method
        protected override bool DeveUserMaximaTaxa(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
           return orcamento.Valor * 0.05;
        }
    }
}

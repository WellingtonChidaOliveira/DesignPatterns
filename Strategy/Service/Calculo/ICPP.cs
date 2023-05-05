using Strategy.Models;
using Strategy.Models.Interfacer;
using Strategy.Models.Template;

namespace Strategy.Service.Calculo
{
    internal class ICPP : TemplateDeImpostoCondicional
    {

        //Template Method
        public override bool DeveUserMaximaTaxa(Orcamento orcamento)
        {
            return orcamento.Valor >= 500;
        }

        public override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.07;
        }

        public override double MinimaTaxacao(Orcamento orcamento)
        {
           return orcamento.Valor * 0.05;
        }
    }
}

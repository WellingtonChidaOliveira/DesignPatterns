using Strategy.Models;
using Strategy.Models.Interfacer;
using Strategy.Models.Template;

namespace Strategy.Service.Calculo
{
    internal class IKCV : TemplateDeImpostoCondicional
    {
        public IKCV(Imposto outroImposto) : base(outroImposto) { }
        public IKCV() : base() { }
        //Template Method
        protected override bool DeveUserMaximaTaxa(Orcamento orcamento)
        {
            return orcamento.Valor > 500 && temItemMaiorQue100Reais(orcamento);
            
        }

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.10;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.06;
        }

        private bool temItemMaiorQue100Reais(Orcamento orcamento)
        {
            foreach (var item in orcamento.Itens)
            {
                if (item.Valor>100)
                {
                    return true;
                }

            }
            return false;
        }
    }
}

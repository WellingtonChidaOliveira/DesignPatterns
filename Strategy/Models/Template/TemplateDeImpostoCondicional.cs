using Strategy.Models.Interfacer;

namespace Strategy.Models.Template
{
    public abstract class TemplateDeImpostoCondicional : Imposto
    {
        public TemplateDeImpostoCondicional(Imposto outroImposto) : base(outroImposto) { }
        public TemplateDeImpostoCondicional() : base() { }
        public override double Calcula(Orcamento orcamento)
        {
            if (DeveUserMaximaTaxa(orcamento))
            {
                return MaximaTaxacao(orcamento) + CalculoDoOutroImposto(orcamento);
            }
            return MinimaTaxacao(orcamento) + CalculoDoOutroImposto(orcamento);
        }

        protected abstract bool DeveUserMaximaTaxa(Orcamento orcamento);

        protected abstract double MaximaTaxacao(Orcamento orcamento);

        protected abstract double MinimaTaxacao(Orcamento orcamento);
    }
}

using Strategy.Models.Interfacer;

namespace Strategy.Models.Template
{
    public abstract class TemplateDeImpostoCondicional : IImposto
    {
        public double Calcula(Orcamento orcamento)
        {
            if (DeveUserMaximaTaxa(orcamento))
            {
                return MaximaTaxacao(orcamento);
            }
            return MinimaTaxacao(orcamento);
        }

        protected abstract bool DeveUserMaximaTaxa(Orcamento orcamento);

        protected abstract double MaximaTaxacao(Orcamento orcamento);

        protected abstract double MinimaTaxacao(Orcamento orcamento);
    }
}

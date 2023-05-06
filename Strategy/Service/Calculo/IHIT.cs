using Strategy.Models;
using Strategy.Models.Template;

namespace Strategy.Service.Calculo
{
    public class IHIT : TemplateDeImpostoCondicional
    {
        protected override bool DeveUserMaximaTaxa(Orcamento orcamento)
        {
            return ItemComNomeIgual(orcamento);
        }

       

        protected override double MaximaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * 0.13 + 100;
        }

        protected override double MinimaTaxacao(Orcamento orcamento)
        {
            return orcamento.Valor * (0.01 * orcamento.Itens.Count);
        }

        private bool ItemComNomeIgual(Orcamento orcamento)
        {
            //GroupBy junta os itens com o mesmo nome
             return orcamento.Itens.GroupBy(i => i.Nome).Any(x=> x.Count() > 1);
        }
    }
}

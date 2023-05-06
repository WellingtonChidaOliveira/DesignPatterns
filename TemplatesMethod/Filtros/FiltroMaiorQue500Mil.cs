using TemplatesMethod.Models;
using TemplatesMethod.Models.Abstracao;

namespace TemplatesMethod.Filtros
{
    public class FiltroMaiorQue500Mil : Filtro
    {
        public FiltroMaiorQue500Mil(Filtro outroFiltro) : base(outroFiltro) { }

        public FiltroMaiorQue500Mil() : base() { }

        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IList<Conta> filtrada = new List<Conta>();
            foreach (var item in contas)
            {
                if (item.Saldo > 500000)
                {
                    filtrada.Add(item);
                }
            }

            foreach(var item in Proximo(contas))
            {
                filtrada.Add(item);
            }
            return filtrada;
        }
    }
}

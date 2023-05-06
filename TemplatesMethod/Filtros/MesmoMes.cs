using System.Collections.Generic;
using TemplatesMethod.Models;
using TemplatesMethod.Models.Abstracao;

namespace TemplatesMethod.Filtros
{
    public class MesmoMes : Filtro
    {
        public MesmoMes(Filtro outroFiltro) : base(outroFiltro) { }

        public MesmoMes() : base() { }
        public override IList<Conta> Filtra(IList<Conta> contas)
        {
            IList<Conta> filtrada = new List<Conta>();
            foreach (Conta c in contas)
            {
                if (c.Data.Month == DateTime.Now.Month && c.Data.Year == DateTime.Now.Year)
                {
                    filtrada.Add(c);
                }
            }
            foreach (Conta c in Proximo(contas))
            {
                filtrada.Add(c);
            }
            return filtrada;
        }
    }
}

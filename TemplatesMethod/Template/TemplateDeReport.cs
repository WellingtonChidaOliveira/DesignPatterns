using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemplatesMethod.Models;
using TemplatesMethod.Models.Interface;

namespace TemplatesMethod.Template
{
    public abstract class TemplateDeReport : IReport
    {
        public IReport Proximo { get; set; }

        public void Report(Conta conta)
        {
            Cabecalho();
            Corpo(new List<Conta>() { conta });
            Rodape();

            if (Proximo != null)
            {
               Proximo.Report(conta);
            }
          
            

        }

        protected abstract void Cabecalho();
        protected abstract void Rodape();
        protected abstract void Corpo(IList<Conta> contas);

    }
}

using TemplatesMethod.Models;
using TemplatesMethod.Models.Interface;
using TemplatesMethod.Reports;

namespace TemplatesMethod.Controller
{
    public class ExibeReport
    {
        public void Exibe( Conta conta)
        {
            IReport report1 = new ReportSimples ();
            IReport report2 = new ReportCompleto();

            
            report1.Proximo= report2;
            report1.Report(conta);


        }
    }
}

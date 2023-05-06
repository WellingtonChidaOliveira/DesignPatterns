using TemplatesMethod.Models;
using TemplatesMethod.Template;

namespace TemplatesMethod.Reports
{
    public class ReportSimples : TemplateDeReport
    {
        protected override void Cabecalho()
        {
            Console.WriteLine("Banco XYZ");
        }

        protected override void Corpo(IList<Conta> contas)
        {
            foreach (Conta c in contas)
            {
                Console.WriteLine(c.Nome + " - " + c.Email);
            }
        }

        protected override void Rodape()
        {
            Console.WriteLine("(11) 1234-5678");
        }
    }
}

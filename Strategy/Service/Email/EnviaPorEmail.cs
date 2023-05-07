using Strategy.Models;
using Strategy.Models.Interfaces;

namespace Strategy.Service.Email
{
    public class EnviaPorEmail : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("envia por email");
        }
    }
}

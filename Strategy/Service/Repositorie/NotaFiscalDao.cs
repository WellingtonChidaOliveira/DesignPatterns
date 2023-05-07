using Strategy.Models;
using Strategy.Models.Interfaces;

namespace Strategy.Service.Repositorie
{
    public class NotaFiscalDao : IAcaoAposGerarNota
    {
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine("Salva no banco");
        }
    }
}

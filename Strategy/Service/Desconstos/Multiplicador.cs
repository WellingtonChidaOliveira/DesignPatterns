using Strategy.Models;
using Strategy.Models.Interfaces;

namespace Strategy.Service.Desconstos
{
    public class Multiplicador : IAcaoAposGerarNota
    {
        public double Fator { get; set; }

        public Multiplicador(double fator)
        {
            Fator = fator;
        }
        public void Executa(NotaFiscal notaFiscal)
        {
            Console.WriteLine(notaFiscal.ValorBruto * Fator);
        }
    }
}

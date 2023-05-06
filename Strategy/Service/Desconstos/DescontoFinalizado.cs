using Strategy.Models;
using Strategy.Models.Interfaces;

namespace Strategy.Service.Desconstos
{
    public class DescontoFinalizado : IEstadoOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orcamentos reprovados ou finalizados não recebem desconto extra");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento já está finalizado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento já está finalizado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orcamento já está finalizado");
        }
    }
}

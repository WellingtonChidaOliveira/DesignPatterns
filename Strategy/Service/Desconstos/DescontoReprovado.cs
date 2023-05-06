using Strategy.Models;
using Strategy.Models.Interfaces;

namespace Strategy.Service.Desconstos
{
    public class DescontoReprovado : IEstadoOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            throw new Exception("Orcamentos reprovados ou finalizados não recebem desconto extra");
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento já está reprovado");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento já está reprovado");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new DescontoFinalizado();
        }
    }
}

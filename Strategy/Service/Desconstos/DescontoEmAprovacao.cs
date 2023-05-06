using Strategy.Models;
using Strategy.Models.Interfaces;
using System.Drawing;

namespace Strategy.Service.Desconstos
{
    public class DescontoEmAprovacao : IEstadoOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            orcamento.Valor -= orcamento.Valor * 0.05;
        }

        public void Aprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new DescontoAprovado();
        }

        public void Reprova(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new DescontoReprovado();
        }

        public void Finaliza(Orcamento orcamento)
        {
            throw new Exception("Orcamentos em aprovacao não podem ir para finalizado diretamente");
        }
    }
}

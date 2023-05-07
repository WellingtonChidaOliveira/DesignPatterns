using Strategy.Models;
using Strategy.Models.Interfaces;
using System.Drawing;

namespace Strategy.Service.Desconstos
{
    public class DescontoAprovado : IEstadoOrcamento
    {
        public void AplicaDescontoExtra(Orcamento orcamento)
        {
            if (!orcamento.DescontoAplicado)
            {
                orcamento.Valor -= orcamento.Valor * 0.02;
                orcamento.DescontoAplicado = true;
            }
            else
            {
                throw new Exception("Desconto já aplicado");
            }
        }

        public void Aprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento já está em estado de aprovacao");
        }

        public void Reprova(Orcamento orcamento)
        {
            throw new Exception("Orcamento aprovados não podem ser reprovados");
        }

        public void Finaliza(Orcamento orcamento)
        {
            orcamento.EstadoAtual = new DescontoFinalizado();
        }
    }
}

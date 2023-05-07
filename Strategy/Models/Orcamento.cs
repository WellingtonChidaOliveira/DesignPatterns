using Strategy.Models.Interfaces;
using Strategy.Service.Desconstos;

namespace Strategy.Models
{
    public class Orcamento
    {
        public double Valor { get; set; }

        public List<Item> Itens { get; set; }

        public IEstadoOrcamento EstadoAtual { get; set; }

        public bool DescontoAplicado { get; set; }

        public Orcamento(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
            EstadoAtual = new DescontoEmAprovacao();
            DescontoAplicado = false;
        }
        public void AdicionarItem(Item item)
        {
            Itens.Add(item);
        }

        public void ApicaDescontoExtra()
        {
            EstadoAtual.AplicaDescontoExtra(this);
            
        }

        public void Aprova()
        {
            EstadoAtual.Aprova(this);
        }

        public void Reprova()
        {
            EstadoAtual.Reprova(this);
        }

        public void Finaliza()
        {
            EstadoAtual.Finaliza(this);
        }

    }

}

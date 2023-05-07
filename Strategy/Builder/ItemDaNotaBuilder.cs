using Strategy.Models;

namespace Strategy.Builder
{
    public class ItemDaNotaBuilder
    {
        public string Nome { get; set; }
        public double Valor { get; set; }
        public ItemDaNota CreatorItemDaNota()
        {
            return new ItemDaNota(Nome, Valor);
        }
        public ItemDaNotaBuilder NomeItemDaNota(string nome)
        {
            this.Nome = nome;
            return this;
        }
        public ItemDaNotaBuilder ValorItemDaNota(double valor)
        {
            this.Valor = valor;
            return this;
        }
    }
}

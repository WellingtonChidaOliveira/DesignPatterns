namespace DesignPatterns.ChainResposability.Models
{
    public class OrcamentoErase
    {
        public double Valor { get; private set; }
        public IList<Item> Itens { get; set; }
        public OrcamentoErase(double valor)
        {
            Valor = valor;
            Itens = new List<Item>();
        }

        public void AdicionarItem(Item item)
        {
            Itens.Add(item);
        }
    }
}

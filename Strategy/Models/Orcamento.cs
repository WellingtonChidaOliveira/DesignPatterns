namespace Strategy.Models
{
    public class Orcamento
    {
        public double Valor { get; set; }

        public List<Item> Itens { get; set; }

        public Orcamento(double valor)
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

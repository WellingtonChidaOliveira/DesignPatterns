namespace Memento.Mirror
{
    public class Historico
    {
        private IList<Estado> Estados = new List<Estado>();

        public void Adiciona(Estado estado)
        {
            Estados.Add(estado);
        }

        public Estado Pega(int index)
        {
            return Estados[index];
        }
    }
}

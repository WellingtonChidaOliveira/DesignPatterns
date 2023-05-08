using Memento.Model;

namespace Memento.Mirror
{
    public class Estado
    {
        public Contrato Contrato { get; private set; }
        public Estado(Contrato contrato)
        {
            Contrato = contrato;
        }
    }
}

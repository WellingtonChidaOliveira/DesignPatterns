using Interpreter.Models.Interface;

namespace Interpreter.Models
{
    public class Multiplicacao : IExpressao
    {
        private IExpressao _esquerda;
        private IExpressao _direita;

        public Multiplicacao(IExpressao esquerda, IExpressao direita)
        {
            _esquerda = esquerda;
            _direita = direita;
        }
        public int Avalia()
        {
            int valorEsquerda = _esquerda.Avalia();
            int valorDireita = _direita.Avalia();
            return valorEsquerda * valorDireita;
        }
    }
}

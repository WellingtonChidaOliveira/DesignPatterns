using Interpreter.Models.Interface;

namespace Interpreter.Models
{
    public class Subtracao : IExpressao
    {
        IExpressao _esquerda;
        IExpressao _direita;

        public Subtracao(IExpressao esquerda, IExpressao direita)
        {
            _esquerda = esquerda;
            _direita = direita;
        }

        public int Avalia()
        {
            int valorEsquerda = _esquerda.Avalia();
            int valorDireita = _direita.Avalia();
            return valorEsquerda - valorDireita;
        }
    }
}

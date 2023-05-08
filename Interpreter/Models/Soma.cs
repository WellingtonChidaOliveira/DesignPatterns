using Interpreter.Models.Interface;

namespace Interpreter.Models
{
    public class Soma : IExpressao
    {
        private IExpressao _esquerda;
        private IExpressao _direita;
        public Soma(IExpressao esquerda, IExpressao direita)
        {
            _esquerda = esquerda;
            _direita = direita;
        }

        public void Aceita(IVisitor impressora)
        {
            return impressora.ImprimeSoma(this);
        }

        public int Avalia()
        {
            int valorEsquerda = _esquerda.Avalia();
            int valorDireita = _direita.Avalia();
            return valorEsquerda + valorDireita;
        }
    }
}

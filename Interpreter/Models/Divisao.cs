using Interpreter.Models.Interface;

namespace Interpreter.Models
{
    public class Divisao : IExpressao
    {
        public IExpressao _esquerda;
        public IExpressao _direita;

        public Divisao(IExpressao esquerda, IExpressao direita)
        {
            _esquerda = esquerda;
            _direita = direita;
        }

        public void Aceita(IVisitor impressora)
        {
            return impressora.ImprimeDivisao(this);
        }

        public int Avalia()
        {
            int valorEsquerda = _esquerda.Avalia();
            int valorDireita = _direita.Avalia();
            return valorEsquerda / valorDireita;
        }
    }
}

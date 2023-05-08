using Interpreter.Models.Interface;

namespace Interpreter.Models
{
    public class RaizQuadrada : IExpressao
    {
        public IExpressao _expressao;

        public RaizQuadrada( IExpressao expressao)
        {
            _expressao= expressao;
        }

        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeRaizQuadrada(this);
        }

        public int Avalia()
        {
            return (int)Math.Sqrt(_expressao.Avalia());
        }
    }
}

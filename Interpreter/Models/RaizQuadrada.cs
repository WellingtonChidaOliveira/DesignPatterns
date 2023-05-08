using Interpreter.Models.Interface;

namespace Interpreter.Models
{
    public class RaizQuadrada : IExpressao
    {
        private IExpressao _expressao;

        public RaizQuadrada( IExpressao expressao)
        {
            _expressao= expressao;
        }

        public int Avalia()
        {
            return (int)Math.Sqrt(_expressao.Avalia());
        }
    }
}

using Interpreter.Models.Interface;

namespace Interpreter.Models
{
    public class Numero : IExpressao
    {
        private int _numero;
        public Numero(int numero)
        {
            _numero = numero;
        }
        public int Avalia()
        {
            return _numero;
        }
    }
}

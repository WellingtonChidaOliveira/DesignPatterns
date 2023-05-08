using Interpreter.Models.Interface;

namespace Interpreter.Models
{
    public class Numero : IExpressao
    {
        public int _numero;
        public Numero(int numero)
        {
            _numero = numero;
        }

        public void Aceita(IVisitor impressora)
        {
            impressora.ImprimeNumero(this);
        }

        public int Avalia()
        {
            return _numero;
        }
    }
}

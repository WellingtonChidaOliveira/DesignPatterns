using Interpreter.Models.Interface;

namespace Interpreter.Models
{
    public class Impressora : IVisitor
    {
        public void ImprimeDivisao(Divisao divisao)
        {
            Console.WriteLine("(");
            divisao._esquerda.Aceita(this);
            Console.WriteLine("/");
            divisao._direita.Aceita(this);
            Console.WriteLine(")");
        }

        public void ImprimeMultiplicacao(Multiplicacao multiplicacao)
        {
            Console.WriteLine("(");
            multiplicacao._esquerda.Aceita(this);
            Console.WriteLine("*");
            multiplicacao._direita.Aceita(this);
            Console.WriteLine(")");
        }

        public void ImprimeNumero(Numero numero)
        {
            Console.WriteLine("(");
            Console.WriteLine(numero._numero);
            Console.WriteLine(")");
        }

        public void ImprimeRaizQuadrada(RaizQuadrada raizQuadrada)
        {
            Console.WriteLine("(");
            Console.WriteLine("√");
            raizQuadrada._expressao.Aceita(this);
            Console.WriteLine(")");
        }

        public void ImprimeSoma(Soma soma)
        {
            throw new NotImplementedException();
        }

        public void ImprimeSubtracao(Subtracao subtracao)
        {
            throw new NotImplementedException();
        }
    }
}

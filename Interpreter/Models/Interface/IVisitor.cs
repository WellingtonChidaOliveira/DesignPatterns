namespace Interpreter.Models.Interface
{
    public interface IVisitor
    {
        void ImprimeSoma(Soma soma);
        void ImprimeSubtracao(Subtracao subtracao);
        void ImprimeDivisao(Divisao divisao);
        void ImprimeMultiplicacao(Multiplicacao multiplicacao);
        void ImprimeNumero(Numero numero);
        void ImprimeRaizQuadrada(RaizQuadrada raizQuadrada);
    }
}

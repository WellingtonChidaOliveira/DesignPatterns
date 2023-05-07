using TemplatesMethod.Models;
using TemplatesMethod.Models.Interface;

namespace TemplatesMethod.States
{
    public class Positivo : ISituacao
    {
        public void Deposita(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.98;
        }

        public void Saca(Conta conta, double valor)
        {
            conta.Saldo -= valor;

            if (conta.Saldo < 0) conta.Situacao = new Negativo();
        }
    }
}

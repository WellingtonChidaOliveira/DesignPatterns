using TemplatesMethod.Models;
using TemplatesMethod.Models.Interface;

namespace TemplatesMethod.States
{
    public class Negativo : ISituacao
    {
        public void Deposita(Conta conta, double valor)
        {
            conta.Saldo += valor * 0.95;
            if (conta.Saldo > 0) conta.Estado = new Positivo();
        }

        public void Saca(Conta conta, double valor)
        {
            throw new Exception("Sua conta está no vermelho. Não é possível sacar!");
        }
    }
}

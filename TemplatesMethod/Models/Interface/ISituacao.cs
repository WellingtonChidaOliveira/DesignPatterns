namespace TemplatesMethod.Models.Interface
{
    public interface ISituacao
    {

        void Saca(Conta conta, double valor);
        void Deposita(Conta conta, double valor);


    }
}

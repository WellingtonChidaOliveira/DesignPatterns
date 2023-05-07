using TemplatesMethod.Models.Interface;
using TemplatesMethod.States;

namespace TemplatesMethod.Models
{
    public class Conta
    {
        public string Nome { get; set; }
        public string NomeDoBanco { get; set; }
        public string Telefone { get; set; }
        public string Email { get; set; }

        public string Endereco { get; set; }
        public DateTime Data { get; set; }

        public double Saldo { get; set; }

        public ISituacao Situacao { get; set; }

        public Conta(string nome, string nomeDoBanco, string telefone,string email ,string endereco)
        {
            Nome = nome;
            NomeDoBanco = nomeDoBanco;
            Telefone = telefone;
            Endereco = endereco;
            Email = email;
            Data = DateTime.Now;
            Situacao = new Positivo();
        }

        public void Saca(double valor)
        {
            Situacao.Saca(this, valor);
        }

        public void Deposita(double valor)
        {
            Situacao.Deposita(this, valor);
        }

    }
}

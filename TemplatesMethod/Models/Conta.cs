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

        public Conta(string nome, string nomeDoBanco, string telefone,string email ,string endereco)
        {
            Nome = nome;
            NomeDoBanco = nomeDoBanco;
            Telefone = telefone;
            Endereco = endereco;
            Email = email;
            Data = DateTime.Now;
        }
    }
}

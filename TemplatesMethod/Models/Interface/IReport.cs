namespace TemplatesMethod.Models.Interface
{
    public interface IReport
    {
        void Report(Conta conta);

        IReport Proximo { get; set; }
    }
}

namespace Jobers.Domain.Model
{
    public class Nota : IComponenteEntidade
    {
        public decimal Valor { get; set; }
        public string Motivo { get; set; }
    }
}
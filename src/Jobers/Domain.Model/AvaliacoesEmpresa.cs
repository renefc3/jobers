namespace Jobers.Domain.Model
{
    public class AvaliacoesEmpresa : BaseEntidade<AvaliacoesEmpresa>
    {
        public string Avaliacao { get; set; }

        public Nota Ambiente { get; set; }
    }
}
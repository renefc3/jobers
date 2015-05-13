namespace Jobers.Domain.Model
{
    public class Tag : BaseEntidade<Tag>
    {
        public string Nome { get; set; }

        public int QtdVagas { get; set; }

        public int QtdProfissionais { get; set; }
    }
}
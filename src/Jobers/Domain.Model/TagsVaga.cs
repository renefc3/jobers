namespace Jobers.Domain.Model
{
    public class TagsVaga : BaseEntidade<TagsVaga>
    {
        public Vaga Vaga { get; set; }
        public Tag Tag { get; set; }

    }
}
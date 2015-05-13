namespace Jobers.Domain.Model
{
    public class TagsProfissional : BaseEntidade<TagsProfissional>
    {
        public Profissional Profissional { get; set; }
        public Tag Tag { get; set; }

    }
}
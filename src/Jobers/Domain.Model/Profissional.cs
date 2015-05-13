namespace Jobers.Domain.Model
{
    public class Profissional : BaseEntidade<Profissional>
    {
        public string Login { get; set; }
        public string Senha { get; set; }
        public string LinkedInUrl { get; set; }
        public string Curriculum { get; set; }
        public string Nome { get; set; }

    }
}
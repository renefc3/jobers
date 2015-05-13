namespace Jobers.Domain.Model
{
    public class Empresa : BaseEntidade<Empresa>
    {
        public string Login { get; set; }
        public string Senha { get; set; }

        public string Nome { get; set; }


    }
}
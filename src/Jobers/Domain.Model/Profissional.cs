using System;

namespace Jobers.Domain.Model
{
    public class Profissional : BaseEntidade<Profissional>
    {
        public string NomeCompleto { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Email { get; set; }

        public string Sexo { get; set; }
        public string Estado { get; set; }
        public string Cidade { get; set; }
        public string Telefone { get; set; }

        public string Cpf { get; set; }
        public string Senha { get; set; }


        public string LinkedInUrl { get; set; }
        public string Curriculum { get; set; }

    }
}
using System;

namespace Jobers.Domain.Model
{
    public interface IVagaRepositorio
    {
    }

    public class Vaga : BaseEntidade<Vaga>
    {
        public string NomeEmpresa { get; set; }
        public string Email { get; set; }
        public string Descricao { get; set; }
        public string Titulo { get; set; }

        public MediaSalarial Salario { get; set; }
        public Decimal PretensaoSalarial { get; set; }
    }

    public enum ConfiguracoesSistema 
    {
        ArquivoNHibenate = 1,

    }
}
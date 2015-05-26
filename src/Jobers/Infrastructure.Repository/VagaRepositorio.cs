using Jobers.Domain.Model;

namespace Infrastructure.Repository
{
    public class VagaRepositorio : BaseRepositorio<Vaga>, IVagaRepositorio
    {
      
    }

    public class AvaliacoesEmpresaRepositorio : BaseRepositorio<AvaliacoesEmpresa>, IAvaliacoesEmpresaRepositorio
    {

    }

    public class SalariosEmpresaRepositorio : BaseRepositorio<SalariosEmpresa>, ISalariosEmpresaRepositorio
    {

    }

}
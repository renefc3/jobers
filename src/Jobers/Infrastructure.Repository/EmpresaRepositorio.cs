using Jobers.Domain.Model;

namespace Infrastructure.Repository
{
    public class BaseRepositorio<T> : IRepositorio<T> where T : IEntidade
    {
        public void Salvar(T entidade)
        {
            

        }
    }
    public class EmpresaRepositorio : BaseRepositorio<Empresa>, IEmpresaRepositorio
    {
    }
}
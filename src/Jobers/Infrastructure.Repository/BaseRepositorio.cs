using Jobers.Domain.Model;

namespace Infrastructure.Repository
{
    public class BaseRepositorio<T> : IRepositorio<T> where T : IEntidade
    {
        public void Salvar(T entidade)
        {
            

        }

        public T BuscarPor(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Excluir(T entidade)
        {
            throw new System.NotImplementedException();
        }
    }
}
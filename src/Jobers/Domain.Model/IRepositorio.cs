namespace Jobers.Domain.Model
{
    public interface IRepositorio<T> where T:IEntidade
    {
        T BuscarPor(int id);
        void Salvar(T entidade);
        void Excluir(T entidade);

    }
}
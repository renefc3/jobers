namespace Jobers.Domain.Model
{
    public enum MediaSalarial
    {
        Abaixo1000 = 1,
        Acima1000Abaixo3500 = 2,
        Acima3500Abaixo5500 = 3,
        Acima5500Abaixo7500 = 4,
        Acima7500Abaixo9500 = 5,
        Acima9500 = 6

    }


    public class BaseEntidade<T> : IEntidade where T : IEntidade
    {
        public int Id { get; set; }

    }

    public interface IEntidade
    {
        int Id { get; set; }


    }
}

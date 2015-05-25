using Jobers.Domain.VM;

namespace Jobers.Domain.Service
{
    public interface IProfissionalServico
    {
        ProfissionalPesquisarResponseVM Pesquisar(ProfissionalPesquisarRequestVM requestVm);
        ProfissionalSalvarResponseVM Salvar(ProfissionalSalvarRequestVM requestVm);
    }
}
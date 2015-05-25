using Jobers.Domain.VM;

namespace Jobers.Domain.Service
{

    public interface IVagaServico
    {
        VagaAdicionarVagaResponseVM AdicionarVaga(VagaAdicionarVagaRequestVM requestVm);
        VagaPesquisarResponseVM Pesquisar(VagaPesquisarRequestVM requestVm);
    }
}

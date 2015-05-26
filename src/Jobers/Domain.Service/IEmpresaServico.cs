using Jobers.Domain.VM;

namespace Jobers.Domain.Service
{
    public interface IEmpresaServico
    {
        EmpresaPesquisarResponseVM Pesquisar(EmpresaPesquisarRequestVM requestVm);
        EmpresaSalvarResponseVM Salvar(EmpresaSalvarRequestVM requestVm);
        EmpresaAvaliarResponseVM Avaliar(EmpresaAvaliarRequestVM requestVm);
        EmpresaDefinirSalarioResponseVM DefinirSalario(EmpresaDefinirSalarioRequestVM requestVm);
    }
}
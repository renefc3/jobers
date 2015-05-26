using Jobers.Domain.Model;
using Jobers.Domain.VM;

namespace Jobers.Domain.Service.Implementacao
{
    public class VagaServico : IVagaServico
    {
        private IVagaRepositorio _repVaga;
        public VagaServico( IVagaRepositorio repVaga)
        {
            _repVaga = repVaga;
        }
        public VagaAdicionarVagaResponseVM AdicionarVaga(VagaAdicionarVagaRequestVM requestVm)
        {
           

            return null;

        }

        public VagaPesquisarResponseVM Pesquisar(VagaPesquisarRequestVM requestVm)
        {

            return null;           
        }
    }

    
}

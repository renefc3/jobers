using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Infrastructure.IOC;
using Jobers.Domain.Model;
using Jobers.Domain.VM;

namespace Jobers.Domain.Service.Implementacao
{
    public class VagaServico : IVagaServico
    {
        public VagaAdicionarVagaResponseVM AdicionarVaga(VagaAdicionarVagaRequestVM requestVm)
        {
            IVagaRepositorio repVaga = IOC.Get<IVagaRepositorio>();


            return null;

        }

        public VagaPesquisarResponseVM Pesquisar(VagaPesquisarRequestVM requestVm)
        {

            return null;           
        }
    }

    
}

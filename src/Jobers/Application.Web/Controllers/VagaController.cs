using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Web.Http;
using Infrastructure.IOC;
using Jobers.Domain.Service;
using Jobers.Domain.VM;

namespace Jobers.Application.Web.Controllers
{
    public class VagaController : ApiController
    {

        public VagaAdicionarVagaResponseVM Adicionar(VagaAdicionarVagaRequestVM requestVm)
        {
            IVagaServico srvVaga = IOC.Get<IVagaServico>();
            VagaAdicionarVagaResponseVM retorno = srvVaga.AdicionarVaga(requestVm);
            return retorno;
        }



        public VagaPesquisarResponseVM Pesquisar(VagaPesquisarRequestVM requestVm)
        {
            IVagaServico srvVaga = IOC.Get<IVagaServico>();
            VagaPesquisarResponseVM retorno = srvVaga.Pesquisar(requestVm);
            return retorno;
        }




    }

}

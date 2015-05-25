using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Infrastructure.IOC;
using Jobers.Domain.Service;
using Jobers.Domain.VM;

namespace Jobers.Application.Web.Controllers
{
    public class ProfissionalController : ApiController
    {
        public ProfissionalPesquisarResponseVM Pesquisar(ProfissionalPesquisarRequestVM requestVm)
        {
            IProfissionalServico srvProfissional = IOC.Get<IProfissionalServico>();

            return srvProfissional.Pesquisar(requestVm);
        }


        public ProfissionalSalvarResponseVM Salvar(ProfissionalSalvarRequestVM requestVm)
        {
            IProfissionalServico srvProfissional = IOC.Get<IProfissionalServico>();

            return srvProfissional.Salvar(requestVm);
   
        }



    }

    
}

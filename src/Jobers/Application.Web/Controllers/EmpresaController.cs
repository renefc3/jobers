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
    public class EmpresaController : ApiController
    {
        public EmpresaPesquisarResponseVM Pesquisar(EmpresaPesquisarRequestVM requestVm)
        {
            IEmpresaServico srvEmpresa = IOC.Get<IEmpresaServico>();
            return srvEmpresa.Pesquisar(requestVm);
        }

        public EmpresaSalvarResponseVM Salvar(EmpresaSalvarRequestVM requestVm)
        {
            IEmpresaServico srvEmpresa = IOC.Get<IEmpresaServico>();
            return srvEmpresa.Salvar(requestVm);
        }

        public EmpresaAvaliarResponseVM Avaliar(EmpresaAvaliarRequestVM requestVm)
        {
            IEmpresaServico srvEmpresa = IOC.Get<IEmpresaServico>();
            return srvEmpresa.Avaliar(requestVm);

        }

        public EmpresaDefinirSalarioResponseVM DefinirSalario(EmpresaDefinirSalarioRequestVM requestVm)
        {
            IEmpresaServico srvEmpresa = IOC.Get<IEmpresaServico>();
            return srvEmpresa.DefinirSalario(requestVm);
        }

    }

    
}

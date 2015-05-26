using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using Infrastructure.Repository;
using Jobers.Domain.Model;
using Jobers.Domain.Service;
using Jobers.Domain.Service.Implementacao;

namespace Infrastructure.IOC
{
    internal class Instalador :   IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(
                Component.For<IEmpresaServico>().ImplementedBy<EmpresaServico>(),
                Component.For<IVagaServico>().ImplementedBy<VagaServico>(),

                Component.For<IAvaliacoesEmpresaRepositorio>().ImplementedBy<AvaliacoesEmpresaRepositorio>(),
                Component.For<ISalariosEmpresaRepositorio>().ImplementedBy<SalariosEmpresaRepositorio>(),
                Component.For<IEmpresaRepositorio>().ImplementedBy<EmpresaRepositorio>(),
                Component.For<IVagaRepositorio>().ImplementedBy<VagaRepositorio>()


                );
        }
    }
}
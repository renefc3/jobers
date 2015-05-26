using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Jobers.Domain.VM
{
    public class RequestBaseVM<T>
    {
        public CabecalhoRequestVM Cabecalho { get; set; }
        public T Entrada { get; set; }
    }

    public class CabecalhoRequestVM
    {
        public int IdUsuario { get; set; }
        public string Token { get; set; }
    }


    public class ResponseBaseVM<T>
    {
        public CabecalhoResponseVM Cabecalho { get; set; }
        public T Saida { get; set; }
    }

    public class CabecalhoResponseVM
    {
        public StatusResponse Status { get; set; }
        public string Mensagem { get; set; }
    }

    public enum StatusResponse
    {
        Sucesso = 1,
        Erro = 2
    }

    public class VagaAdicionarVagaResponseVM
    {
    }

    public class VagaAdicionarVagaRequestVM
    {
    }

    public class EmpresaSalvarResponseVM
    {
    }

    public class EmpresaSalvarRequestVM
    {
    }

    public class EmpresaPesquisarRequestVM
    {
    }

    public class EmpresaPesquisarResponseVM
    {
    }

    public class ProfissionalPesquisarRequestVM
    {
    }

    public class ProfissionalSalvarRequestVM
    {
    }

    public class ProfissionalSalvarResponseVM
    {
    }

    public class ProfissionalPesquisarResponseVM
    {
    }

    public class VagaPesquisarResponseVM
    {
    }

    public class VagaPesquisarRequestVM
    {
    }

    public class EmpresaDefinirSalarioRequestVM : RequestBaseVM<EmpresaDefinirSalarioRequestVM.EntradaEmpresaDefinirSalarioRequestVM>
    {
        public class EntradaEmpresaDefinirSalarioRequestVM
        {
            public int IdEmpresa { get; set; }
            public string NomeEmpresa { get; set; }
            public string SiteEmpresa { get; set; }

            public bool TrabalhaAtualmente { get; set; }
            public decimal Salario { get; set; }
            public int TipoContracao { get; set; }
            public string RamoEmpresa { get; set; }
            public string Cidade { get; set; }
        }
    }

    public class EmpresaDefinirSalarioResponseVM
    {
    }

    public class EmpresaAvaliarResponseVM : RequestBaseVM<EmpresaAvaliarResponseVM.SaidaEmpresaAvaliarResponseVM>
    {
        public class SaidaEmpresaAvaliarResponseVM
        {
         

        }
    }

    

    public class EmpresaAvaliarRequestVM : RequestBaseVM<EmpresaAvaliarRequestVM.EntradaEmpresaAvaliarRequestVM>
    {
        public class EntradaEmpresaAvaliarRequestVM
        {
            public int IdEmpresa { get; set; }
            public string NomeEmpresa { get; set; }
            public string SiteEmpresa { get; set; }

            public bool TrabalhaAtualmente { get; set; }
            public string TituloAvaliacao { get; set; }
            public string PontosPositivos { get; set; }
            public string PontosNegativos { get; set; }
            public string Cargo { get; set; }
            public string Cidade { get; set; }
            public string MelhoriasParaEmpresa { get; set; }
            public string RamoEmpresa { get; set; }
        }
    }


}

namespace Jobers.Domain.Model
{

    public class SalariosEmpresa : BaseEntidade<SalariosEmpresa>
    {
        public virtual Empresa Empresa { get; set; }
        public virtual string NomeEmpresa { get; set; }
        public virtual string RamoEmpresa { get; set; }
        public virtual string SiteEmpresa { get; set; }
        public virtual string Estado { get; set; }
        public virtual string Cidade { get; set; }

        public virtual bool TrabalhaAtualmente { get; set; }
        public virtual decimal Salario { get; set; }
        public virtual TipoContratacao TipoContratacao { get; set; }


    }

    public enum TipoContratacao
    {
        CLT = 1,
        CLT_FLEX = 2,
        PJ = 3,
        Estagiario = 4
    }

    public class AvaliacoesEmpresa : BaseEntidade<AvaliacoesEmpresa>
    {
        public virtual Empresa Empresa { get; set; }
        public virtual string NomeEmpresa { get; set; }
        public virtual string RamoEmpresa { get; set; }
        public virtual string SiteEmpresa { get; set; }

        public virtual bool TrabalhaAtualmente { get; set; }
        public virtual string TituloAvaliacao { get; set; }
        public virtual string PontosPositivos { get; set; }
        public virtual string PontosNegativos { get; set; }
        public virtual string Cargo { get; set; }
        public virtual string Cidade { get; set; }
        public virtual string MelhoriasParaEmpresa { get; set; }

        public Nota Satisfacao { get; set; }

    }
}
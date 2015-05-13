using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FluentNHibernate.Mapping;
using Jobers.Domain.Model;

namespace Jobers.Infrastructure.Repository.Map
{
    public class BaseClassMap<T> : ClassMap<T> where T : IEntidade
    {
        public BaseClassMap()
        {
            Id(x => x.Id).GeneratedBy.Identity();
        }
    }

    public class VagaMap : BaseClassMap<Vaga>
    {
        public VagaMap()
        {
            Table("vaga");

            Map(x => x.Descricao).Length(450);
            Map(x => x.Email).Length(50);
            Map(x => x.NomeEmpresa).Length(50);
            Map(x => x.PretensaoSalarial);
            Map(x => x.Salario);
            Map(x => x.Titulo).Length(50);
        }
    }

    public class ProfissionalMap : BaseClassMap<Profissional>
    {
        public ProfissionalMap()
        {
            Table("profissional");

            Map(x => x.Curriculum).Length(Int16.MaxValue);
            Map(x => x.LinkedInUrl).Length(150);
            Map(x => x.Login).Length(30);
            Map(x => x.Nome).Length(300);
            Map(x => x.Senha);
            
        }
    }
    public class EmpresaMap : BaseClassMap<Empresa>
    {
        public EmpresaMap()
        {
            Table("empresa");

            Map(x => x.Login).Length(30);
            Map(x => x.Nome).Length(300);
            Map(x => x.Senha);
        }
    }


    public class TagMap : BaseClassMap<Tag>
    {
        public TagMap()
        {
            Table("tag");

            Map(x => x.Nome).Length(300);
            Map(x => x.QtdProfissionais);
            Map(x => x.QtdVagas);
            
        }
    }


    public class TagsProfissionalMap : BaseClassMap<TagsProfissional>
    {
        public TagsProfissionalMap()
        {
            Table("tag_profisisona");

            References(x => x.Profissional);
            References(x => x.Tag);
            
        }
    }

    public class TagsVagaMap : BaseClassMap<TagsVaga>
    {
        public TagsVagaMap()
        {
            Table("tag_vaga");
            References(x => x.Vaga);
            References(x => x.Tag);
        }
    }


}

﻿using System;
using Jobers.Domain.Model;
using Jobers.Domain.VM;

namespace Jobers.Domain.Service.Implementacao
{
    public class EmpresaServico : IEmpresaServico
    {

        private IAvaliacoesEmpresaRepositorio _repAvaliacoesEmpresa;
        private ISalariosEmpresaRepositorio _repSalarioEmpresa;
        private IEmpresaRepositorio _repEmpresa;

        public EmpresaServico(IAvaliacoesEmpresaRepositorio repAvaliacoesEmpresa, ISalariosEmpresaRepositorio repSalarioEmpresa, IEmpresaRepositorio repEmpresa)
        {
            _repAvaliacoesEmpresa = repAvaliacoesEmpresa;
            _repSalarioEmpresa = repSalarioEmpresa;
            _repEmpresa = repEmpresa;
        }

        public EmpresaPesquisarResponseVM Pesquisar(EmpresaPesquisarRequestVM requestVm)
        {
            throw new NotImplementedException();
        }

        public EmpresaSalvarResponseVM Salvar(EmpresaSalvarRequestVM requestVm)
        {
            throw new NotImplementedException();
        }

        public EmpresaAvaliarResponseVM Avaliar(EmpresaAvaliarRequestVM requestVm)
        {
            AvaliacoesEmpresa avaliacao = new AvaliacoesEmpresa();
            avaliacao.Cargo = requestVm.Entrada.Cargo;
            avaliacao.Cidade = requestVm.Entrada.Cidade;
            avaliacao.Empresa = _repEmpresa.BuscarPor(requestVm.Entrada.IdEmpresa);
            avaliacao.NomeEmpresa = requestVm.Entrada.NomeEmpresa;
            avaliacao.MelhoriasParaEmpresa = requestVm.Entrada.MelhoriasParaEmpresa;
            avaliacao.PontosNegativos = requestVm.Entrada.PontosNegativos;
            avaliacao.PontosPositivos = requestVm.Entrada.PontosPositivos;
            avaliacao.RamoEmpresa = requestVm.Entrada.RamoEmpresa;
            //avaliacao.Satisfacao = requestVm.Entrada.;
            avaliacao.SiteEmpresa = requestVm.Entrada.SiteEmpresa;
            avaliacao.TituloAvaliacao = requestVm.Entrada.TituloAvaliacao;
            avaliacao.TrabalhaAtualmente = requestVm.Entrada.TrabalhaAtualmente;

            _repAvaliacoesEmpresa.Salvar(avaliacao);

            return new EmpresaAvaliarResponseVM();
        }

        public EmpresaDefinirSalarioResponseVM DefinirSalario(EmpresaDefinirSalarioRequestVM requestVm)
        {
            SalariosEmpresa salario = new SalariosEmpresa();

            salario.Cidade = requestVm.Entrada.Cidade;
            salario.Empresa = _repEmpresa.BuscarPor(requestVm.Entrada.IdEmpresa);
            salario.NomeEmpresa = requestVm.Entrada.NomeEmpresa;
            salario.Salario = requestVm.Entrada.Salario;
            salario.RamoEmpresa = requestVm.Entrada.RamoEmpresa;
            salario.SiteEmpresa = requestVm.Entrada.SiteEmpresa;
            salario.TipoContratacao = (TipoContratacao)requestVm.Entrada.TipoContracao;
            salario.TrabalhaAtualmente = requestVm.Entrada.TrabalhaAtualmente;
            _repSalarioEmpresa.Salvar(salario);

            return new EmpresaDefinirSalarioResponseVM();
        }
    }
}
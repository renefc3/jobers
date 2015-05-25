﻿using System;
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

}

﻿using Pso.Domain.Enum;
using System;
using System.Collections.Generic;

namespace Pso.Api.ViewModel
{
    public class ClienteViewModel
    {
        public long Id { get; set; }
        public string Nome { get; set; }
        public string Rg { get; set; }
        public string Cpf { get; set; }
        public string Filiacao { get; set; }
        public bool IsSPC { get; set; }
        public DateTime Nascimento { get; set; }
        public SexoType Sexo { get; set; }
        public EnderecoViewModel Endereco { get; set; }
        public ICollection<ContatoViewModel> Contatos { get; set; }
    }
}
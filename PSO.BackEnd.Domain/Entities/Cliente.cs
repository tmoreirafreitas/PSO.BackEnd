﻿using PSO.BackEnd.Domain.Enum;
using PSO.BackEnd.Domain.Validators;
using System;
using System.Collections.Generic;

namespace PSO.BackEnd.Domain.Entities
{
    public class Cliente : Entity
    {
        public long ClienteId { get; private set; }
        public string Nome { get; private set; }
        public string Rg { get; private set; }
        public string Cpf { get; private set; }
        public string Filiacao { get; private set; }
        public bool? IsSPC { get; private set; }
        public string Email { get; private set; }
        public DateTime Nascimento { get; private set; }
        public Endereco Endereco { get; private set; }
        public ICollection<Contato> Contatos { get; private set; }
        public ICollection<Pedido> Pedidos { get; private set; }
        public SexoType Sexo { get; private set; }

        public Cliente(string nome, string rg, string cpf, string filiacao, bool? isSPC, string email, DateTime nascimento, Endereco endereco, SexoType sexo)
        {
            Nome = nome;
            Rg = rg;
            Cpf = cpf;
            Filiacao = filiacao;
            IsSPC = isSPC;
            Email = email;
            Nascimento = nascimento;
            Endereco = endereco;
            Contatos = new List<Contato>();
            Pedidos = new List<Pedido>();
            Sexo = sexo;
            Validate(this, new ClienteValidator());
        }
    }
}

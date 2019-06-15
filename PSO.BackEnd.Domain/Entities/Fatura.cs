﻿using PSO.BackEnd.Domain.Enum;
using PSO.BackEnd.Domain.Validators;
using System;
using System.Collections.Generic;

namespace PSO.BackEnd.Domain.Entities
{
    public class Fatura : Entity
    {
        public decimal Valor { get; private set; }
        public decimal Total { get; private set; }
        public decimal Sinal { get; private set; }
        public bool IsPaga { get; private set; }
        public DateTime DataPagamento { get; private set; }
        public int NumeroParcelas { get; private set; }
        public FormaPagamento FormaPagamento { get; private set; }
        public Pedido Pedido { get; private set; }
        public Cliente Cliente { get; private set; }
        public IEnumerable<Parcela> Parcelas { get; private set; }

        public Fatura(decimal valor, decimal total, decimal sinal, bool isPaga, 
            DateTime dataPagamento, int numeroParcelas, FormaPagamento formaPagamento, Pedido pedido, Cliente cliente)
        {
            Valor = valor;
            Total = total;
            Sinal = sinal;
            IsPaga = isPaga;
            DataPagamento = dataPagamento;
            NumeroParcelas = numeroParcelas;
            FormaPagamento = formaPagamento;
            Pedido = pedido;
            Cliente = cliente;
            Parcelas = new List<Parcela>();
            Validate(this, new FaturaValidator());
        }
    }
}

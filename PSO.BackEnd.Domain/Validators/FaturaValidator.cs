﻿using FluentValidation;
using PSO.BackEnd.Domain.Entities;
using System;

namespace PSO.BackEnd.Domain.Validators
{
    public class FaturaValidator : AbstractValidator<Fatura>
    {
        public FaturaValidator()
        {
            RuleFor(f => f).NotNull().OnAnyFailure(fat =>
            {
                throw new ArgumentNullException("O objeto fatura não pode ser nulo.");
            });

            RuleFor(fat => fat.FormaPagamento).NotNull().WithMessage("É necessário informar a forma de pagamento.");
            RuleFor(fat => fat.Total).NotEqual(0).WithMessage("É necessário informar o total da fatura.");
        }
    }
}

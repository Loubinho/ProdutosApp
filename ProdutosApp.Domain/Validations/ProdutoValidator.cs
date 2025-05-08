using FluentValidation;
using ProdutosApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosApp.Domain.Validations
{
    public class ProdutoValidator : FluentValidation.AbstractValidator<Produto>
    {
        public ProdutoValidator()
        {
            RuleFor(p => p.Nome)
                .NotEmpty().WithMessage("O nome do produto é obrigatório.")
                .Length(3, 150).WithMessage("O nome do produto deve ter entre 3 e 150 caracteres.");

            RuleFor(p => p.Preco)
                .NotNull().WithMessage("O preço do produto é obrigatório.")
                .GreaterThan(0).WithMessage("O preço do produto deve ser maior que zero.");

            RuleFor(p => p.Quantidade)
                .NotNull().WithMessage("A quantidade do produto é obrigatória.")
                .GreaterThanOrEqualTo(0).WithMessage("A quantidade do produto deve ser maior ou igual a zero.");

            RuleFor(p => p.DataHoraCriacao)
                .NotNull().WithMessage("A data e hora de criação do produto são obrigatórias.");

            RuleFor(p => p.Ativo)
                .NotNull().WithMessage("O status ativo do produto é obrigatório.");

            RuleFor(p => p.CategoriaId)
                .NotNull().WithMessage("O ID da categoria do produto é obrigatório.")
                .NotEqual(Guid.Empty).WithMessage("O ID da categoria do produto não pode ser vazio.");
        }
    }
}

using FluentValidation;
using ProdutosApp.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProdutosApp.Domain.Validations
{
    /// <summary>
    /// Validator class for the Categoria entity.
    /// </summary>
    public class CategoriaValidator : FluentValidation.AbstractValidator<Categoria>
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoriaValidator"/> class.
        /// </summary>
        public CategoriaValidator()
        {
            RuleFor(c => c.Id)
                .NotEmpty().WithMessage("O ID da categoria é obrigatório.")
                .NotEqual(Guid.Empty).WithMessage("O ID da categoria não pode ser vazio.");
            RuleFor(c => c.Nome)
                .NotEmpty().WithMessage("O nome da categoria é obrigatório.")
                .Length(3, 50).WithMessage("O nome da categoria deve ter entre 3 e 50 caracteres.");
            RuleFor(c => c.Descricao)
                .MaximumLength(200).WithMessage("A descrição da categoria deve ter no máximo 200 caracteres.");
        }
    }
}

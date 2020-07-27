using FluentValidation;
using MASAIO.Business.Enums;
using MASAIO.Business.Models.Validations.Documents;

namespace MASAIO.Business.Models.Validations
{
    public class FornecedorValidation : AbstractValidator<Fornecedor>
    {
        public FornecedorValidation()
        {
            RuleFor(f => f.Nome)
                .NotEmpty().WithMessage("O {PropertyName} deve ser preenchido")
                .Length(2, 100).WithMessage("O campo {PropertyName} precisa ter {MinLenght} e {MaxLength} cadarteres");

            When(f => f.TipoFornecedor == TipoFornecedor.PessoaFisica, () =>
            {
                RuleFor(f => f.Documento.Length)
                    .Equal(CpfValidacao.TamanhoCpf)
                    .WithMessage("O Campo Documento precisa ter {ComparisonValue} caracteres e foi fornecido {PropertyValue}");

                RuleFor(f => CpfValidacao.Validar(f.Documento))
                    .Equal(true)
                    .WithMessage("O Documento fornecido é inválido");
            });

            When(f => f.TipoFornecedor == TipoFornecedor.PessoaJuridica, () =>
            {

                RuleFor(f => f.Documento.Length)
                    .Equal(CnpjValidacao.TamanhoCnpj)
                    .WithMessage("O Campo Documento precisa ter {ComparisonValue} caracteres e foi fornecido {PropertyValue}");

                RuleFor(f => CnpjValidacao.Validar(f.Documento))
                    .Equal(true)
                    .WithMessage("O Documento fornecido é inválido");
            });
        }
    }
}

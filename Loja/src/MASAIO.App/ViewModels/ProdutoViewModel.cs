using MASAIO.Business.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MASAIO.App.ViewModels
{
    public class ProdutoViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [DisplayName("Fornecedor")]
        public Guid FornecedorId { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(3, ErrorMessage = "O Campo {0} deve estar entre {2} e {1} caracteres", MinimumLength = 150)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(3, ErrorMessage = "O Campo {0} deve estar entre {2} e {1} caracteres", MinimumLength = 3)]
        public string Descricao { get; set; }

        [DisplayName("Imagem do Produto")]
        public string Imagem { get; set; }

        [Required(ErrorMessage = "O campo {0} é obrigatório")]
        public decimal Valor { get; set; }

        [ScaffoldColumn(false)]
        public DateTime DataCadastro { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }

        public Fornecedor Fornecedor { get; set; }

    }
}

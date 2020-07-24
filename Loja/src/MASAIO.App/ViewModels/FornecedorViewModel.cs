using MASAIO.Business.Enums;
using MASAIO.Business.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace MASAIO.App.ViewModels
{
    public class FornecedorViewModel
    {
        [Key]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(100, ErrorMessage = "O Campo {0} deve estar entre {2} e {1} caracteres", MinimumLength = 3)]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O Campo {0} é obrigatório")]
        [StringLength(14, ErrorMessage = "O Campo {0} deve estar entre {2} e {1} caracteres", MinimumLength = 11)]
        public string Documento { get; set; }
        
        [DisplayName("Tipo")]
        public TipoFornecedor TipoFornecedor { get; set; }

        [DisplayName("Endereço")]
        public Endereco Endereco { get; set; }

        [DisplayName("Ativo?")]
        public bool Ativo { get; set; }

        public IEnumerable<Produto> Produtos { get; set; }
    }
}

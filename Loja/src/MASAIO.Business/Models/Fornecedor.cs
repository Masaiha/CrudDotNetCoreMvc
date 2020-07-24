using MASAIO.Business.Enums;
using System.Collections.Generic;

namespace MASAIO.Business.Models
{
    public class Fornecedor
    {
        public string Nome { get; set; }
        public string Documento { get; set; }
        public TipoFornecedor TipoFornecedor { get; set; }
        public Endereco Endereco { get; set; }
        public bool Ativo { get; set; }

        /* EF Relations */
        public IEnumerable<Produto> Produtos { get; set; }

    }
}

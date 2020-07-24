using MASAIO.Business.Models;
using System;
using System.Threading.Tasks;

namespace MASAIO.Business.Interfaces
{
    public interface IEnderecoRepository : IRepository<Endereco>
    {
        Task<Endereco> ObterEnderecoPorFornecedor(Guid fornecedorId);

    }
}

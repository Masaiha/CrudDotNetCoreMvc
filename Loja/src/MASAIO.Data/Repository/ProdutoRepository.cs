using MASAIO.Business.Interfaces;
using MASAIO.Business.Models;
using MASAIO.Data.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MASAIO.Data.Repository
{
    public class ProdutoRepository : Repository<Produto>, IProdutoRepository
    {
        public ProdutoRepository(MyContext context) : base(context){ }

        public async Task<Produto> ObterProdutoFornecedor(Guid id)
        {
            return await Db.Produtos.AsNoTracking()
                            .Include(p => p.Fornecedor)
                            .FirstOrDefaultAsync(p => p.Id == id);
        }

        public async Task<IEnumerable<Produto>> ObterProdutosFornecedores()
        {
            return await Db.Produtos.AsNoTracking()
                            .Include(p => p.Fornecedor)
                            .OrderBy(f => f.Nome)
                            .ToListAsync();
        }

        public async Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid fornecedorId)
        {
            return await Db.Produtos.AsNoTracking()
                             .Where(p => p.FornecedorId == fornecedorId)
                             .ToListAsync();

            //return await Buscar(p => p.FornecedorId == fornecedorId);
        }
    }
}

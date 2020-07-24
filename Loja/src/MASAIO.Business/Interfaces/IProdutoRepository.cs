﻿using MASAIO.Business.Models;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MASAIO.Business.Interfaces
{
    interface IProdutoRepository : IRepository<Produto>
    {
        Task<IEnumerable<Produto>> ObterProdutosPorFornecedor(Guid fornecedorId);
        Task<IEnumerable<Produto>> ObterProdutosFornecedores();
        Task<Produto> ObterProdutoFornecedor(Guid id);

    }
}

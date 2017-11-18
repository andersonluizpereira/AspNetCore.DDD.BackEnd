using System;
using System.Collections.Generic;
using System.Text;
using Integration.Domain.Entities.Models;

namespace Integration.Domain.Entities.Interfaces.Produtos
{
    public interface IProdutoRepository : IRepository<ProdutosViewModel>
    {
        IEnumerable<ProdutosViewModel> BuscarProduto(int? id);
    }
}

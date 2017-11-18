using System;
using System.Collections.Generic;
using System.Text;
using Integration.Domain.Entities.Interfaces.Produtos;
using Integration.Domain.Entities.Models;
using Integration.Infra.Data.Contexts;
using Integration.Infra.Data.Repository;

namespace Integration.Infra.Data.Implementations.Produtos
{
     public  class ProdutoRepository : Repository<ProdutosViewModel>, IProdutoRepository
    {
        public ProdutoRepository(Context context) : base(context)
        {
                
        }

        public IEnumerable<ProdutosViewModel> BuscarProduto(int? id)
        {
            return Find(p=>p.Id==id);
        }
    }
}

using Integration.Domain.Entities.Models;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Integration.Application.Interfaces.Produtos
{
    public interface IProdutoApplication
    {
        IEnumerable<ProdutosViewModel> Get();
        ProdutosViewModel Get(Guid id);
        ProdutosViewModel Get(int id);
        void Add(ProdutosViewModel entity);
        void Delete(int id);
        void Update(ProdutosViewModel entity);
        int SaveChanges();
        IEnumerable<ProdutosViewModel> Find(Expression<Func<ProdutosViewModel, bool>> predicate);
    }
}

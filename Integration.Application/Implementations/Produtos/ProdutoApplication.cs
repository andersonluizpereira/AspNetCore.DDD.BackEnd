using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;
using Integration.Application.Interfaces.Produtos;
using Integration.Domain.Entities.Interfaces.Produtos;
using Integration.Domain.Entities.Models;

namespace Integration.Application.Implementations.Produtos
{
    public class ProdutoApplication : IProdutoApplication
    {
        private readonly IProdutoRepository _iProdutoRepository;

        public ProdutoApplication(IProdutoRepository iProdutoRepository)
        {
            _iProdutoRepository = iProdutoRepository;
        }

        public void Add(ProdutosViewModel entity)
        {
            _iProdutoRepository.Add(entity);

        }

        public void Delete(int id)
        {
            _iProdutoRepository.Delete(id);
        }

        public IEnumerable<ProdutosViewModel> Find(Expression<Func<ProdutosViewModel, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<ProdutosViewModel> Get()
        {
            throw new NotImplementedException();
        }

        public ProdutosViewModel Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public ProdutosViewModel Get(int id)
        {
            return _iProdutoRepository.Get(id);
        }

        public int SaveChanges()
        {
            throw new NotImplementedException();
        }

        public void Update(ProdutosViewModel entity)
        {
            _iProdutoRepository.Update(entity);
        }
    }
}

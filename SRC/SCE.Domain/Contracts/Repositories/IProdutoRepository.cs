using SCE.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SCE.Domain.Contracts.Repositories
{
    public interface IProdutoRepository
    {
        void Cadastrar(Produto produto);
        void Atualizar(Produto produto);
        List<Produto> BuscarPorId(Guid id);
        List<Produto> BuscaPor(Expression<Func<Produto, bool>> where);
        int Quantidade(Guid id);
        int QuantidadePor(Expression<Func<Produto, bool>> where);
    }
}

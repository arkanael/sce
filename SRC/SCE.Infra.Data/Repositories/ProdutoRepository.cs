using SCE.Domain.Contracts.Repositories;
using SCE.Domain.Entities;
using SCE.Infra.Data.Contexts;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace SCE.Infra.Data.Repositories
{
    public class ProdutoRepository : DataContext, IProdutoRepository
    {
        public void Cadastrar(Produto produto)
        {
            try
            {
                OpenConnection();

                query = "Insert into Produto(Id, Nome, Modelo) values(@Id, @Nome, @Modelo)";

                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@Id", produto.Id);
                sqlCommand.Parameters.AddWithValue("@Nome", produto.Nome);
                sqlCommand.Parameters.AddWithValue("@Modelo", produto.Modelo);
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception erro)
            {

                throw new Exception("Não foi possível efetuar o cadastro.");
            }
            finally
            {
                CloseConnection();
            }
        }

        public void Atualizar(Produto produto)
        {
            throw new NotImplementedException();
        }

        public List<Produto> BuscarPorId(Guid id)
        {
            throw new NotImplementedException();
        }
       
        public List<Produto> BuscaPor(Expression<Func<Produto, bool>> where)
        {
            throw new NotImplementedException();
        }

        public int Quantidade(Guid id)
        {
            throw new NotImplementedException();
        }

        public int QuantidadePor(Expression<Func<Produto, bool>> where)
        {
            throw new NotImplementedException();
        }
    }
}

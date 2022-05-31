using SCE.Domain.Contracts.Entities;
using SCE.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCE.Domain.Entities
{
    public class Usuario : BaseEntity<Usuario>, IEntity
    {
        public string Nome { get; set; }
        public string Login { get; set; }
        public string Senha { get; set; }
        
        public Usuario Cadastrar(string nome, string login, string senha)
        {
            
            Nome = nome;
            Login = login; 
            Senha = senha;


            return this;
        }

        public void Autalizar(Guid id, string nome, string login, string senha)
        {
            Nome = nome;
            Login = login;
            Senha = senha;
        }

        public override bool Validate()
        {
            if (DataValidation.NaoPodeSerNula(DataCadastro))
                AddNotification("DataCadastro", "A data de cadastro não pode ser uma data nula.");

            if (DataValidation.NaoPodeSerMaiorQueDataAtual(DataCadastro))
                AddNotification("DataCadastro", "A data de cadastro não pode ser menor que a atual.");

            if (StringValidation.NaoPodeSerNulo(Nome))
                AddNotification("Nome", "O nome do produto não pode ser nulo.");
            return (Notifications.Count == 0);

        }

    }
}

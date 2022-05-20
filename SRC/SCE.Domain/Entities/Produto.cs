using SCE.Domain.Contracts.Entities;
using SCE.Domain.Contracts.Validations;
using SCE.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCE.Domain.Entities
{
    public class Produto : BaseEntity<Produto>, IEntity
    {
        
        public string Nome { get; private set; }

        public string Modelo { get; private set; }

        public Produto Cadastrar(string nome, string modelo)
        {
            Nome = nome;
            Modelo = modelo;
            SetDataCadastrado();
            Validate();
            return this;
        }

        public void Atualizar(Guid id, string nome, string modelo)
        {
            Nome = nome;
            Modelo = modelo;
            SetDataAtualizacao();
            Validate();
            
        }

        public override bool Validate()
        {
            if (DataValidation.NaoPodeSerNula(DataCadastro))
                AddNotification("DataCadastro", "A data de cadastro não pode ser uma data nula.");

            if (DataValidation.NaoPodeSerMaiorQueDataAtual(DataCadastro))
                AddNotification("DataCadastro", "A data de cadastro não pode ser menor que a atual.");

            if (StringValidation.NaoPodeSerNulo(Nome))
                AddNotification("Nome", "O nome do produto não pode ser nulo.");

            if (StringValidation.QuantidadeMaximaCaracteres(Nome, 20))
                AddNotification("Nome", "O nome do produto não pode ter mais que 20 caracteres.");

            if (StringValidation.NaoPodeSerNulo(Modelo))
                AddNotification("Modelo", "O modelo do produto não pode ser nulo.");

            if (StringValidation.QuantidadeMaximaCaracteres(Modelo, 20))
                AddNotification("Modelo", "O modelo do produto não pode ter mais que 20 caracteres.");

            return (Notifications.Count == 0);

        }

        public override string ToString()
        {
            return $"{Nome} - {Modelo}";
        }
    }
}

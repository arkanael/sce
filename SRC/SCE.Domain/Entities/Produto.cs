using SCE.Domain.Contracts.Validations;
using SCE.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCE.Domain.Entities
{
    public class Produto : Validable
    {
        

        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Modelo { get; private set; }
        public DateTime DataCadastro { get; private set; }
        public DateTime? DataUltimaAtualizacao { get; private set; }

        public void Cadastrar(string nome, string modelo)
        {
            Id = Guid.NewGuid();
            Nome = nome;
            Modelo = modelo;
            DataCadastro = DateTime.Now;
            DataUltimaAtualizacao = null;
        }

        public void Atualizar(Guid id, string nome, string modelo)
        {
            Id = id;
            Nome = nome;
            Modelo = modelo;
            DataUltimaAtualizacao = DateTime.Now;
        }


        public override string ToString()
        {
            return $"{Nome} - {Modelo}";
        }

        public override bool Validate()
        {
            if (DataValidation.NaoPodeSerNula(DataCadastro))
                AddNotification("DataCadastro", "A data de cadastro não pode ser uma data nula.");

            if (DataValidation.NaoPodeSerMaiorQueDataAtual(DataCadastro))
                AddNotification("DataCadastro", "A data de cadastro não pode ser menor que a atual.");


            return (Notifications.Count == 0);

        }
    }
}

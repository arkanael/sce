using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCE.Domain.Entities
{
    public class Produto
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
    }
}

using SCE.Domain.Contracts.Entities;
using SCE.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCE.Domain.Entities
{
    public abstract class BaseEntity<T> : Validable where T : IEntity
    {
        protected BaseEntity()
        {
            if (Id == null)
            {
                Id = Guid.NewGuid();
            }
        }

        public Guid? Id { get; private set; }

        public DateTime DataCadastro { get; private set; }

        public DateTime? DataUltimaAtualizacao { get; private set; }

        public void SetDataCadastrado()
        {
            DataCadastro = DateTime.Now;
        }

        public void SetDataAtualizacao()
        {
            DataCadastro = DateTime.Now;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCE.Domain.Entities
{
    public class Estoque
    {
        public Guid Id { get; set; }
        public int EstoqueInicial { get; set; }

        public string Observacao { get; set; }



    }
}

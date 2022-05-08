using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCE.Domain.Entities
{
    internal class Produto
    {
        public Guid Id { get; set; }
        public string Nome { get; set; }
        public Fabricante Fabricante { get; set; }
        public string Modelo { get; set; }

        public override string ToString()
        {
            return $"{Nome} - {Fabricante.Nome}";
        }
    }
}

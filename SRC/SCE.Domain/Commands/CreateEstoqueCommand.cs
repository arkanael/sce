using SCE.Domain.Contracts.Commands;
using SCE.Domain.Validations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCE.Domain.Commands
{
    public class CreateEstoqueCommand: Validable, ICommand
    {
        public String Produto { get; set; }
        public int EstoqueInicial { get; set; }
        public int Entrada { get; set; }
        public int Saida { get; set; }
        public int Quantidade { get; set; }

        public override bool Validate()
        {
            throw new NotImplementedException();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCE.Domain.Contracts.Commands
{
    public interface ICommand
    {
        bool Validate();
    }
}

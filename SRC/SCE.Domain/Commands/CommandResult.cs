using SCE.Domain.Contracts.Commands;
using SCE.Domain.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCE.Domain.Commands
{
    public class CommandResult : ICommandResult
    {
        public bool Ok { get; set; }
        public string PropertyName { get; set; }
        public string Message { get; set; }

        public IReadOnlyCollection<Notification> Notifications { get; set; }
    }
}

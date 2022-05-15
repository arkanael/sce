using SCE.Domain.Contracts.Notifications;
using SCE.Domain.Contracts.Validations;
using SCE.Domain.Notifications;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SCE.Domain.Validations
{
    public abstract class Validable : IValidate, INotification
    {
        private List<Notification> _notifications;

        public Validable()
        {
            _notifications = new List<Notification>();
        }

        public IReadOnlyCollection<Notification> Notifications { get { return _notifications; } }

        public void ClearNotifications() 
        { 
            _notifications.Clear(); 
        }

        public void AddNotification(string property, string message)
        {
            _notifications.Add(new Notification(property, message));
        }

        public abstract bool Validate();

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiaryCQRS.Events;

namespace DiaryCQRS.Storage
{
    public interface IEventPublisher
    {
        void Publish(Event @event);
    }
}

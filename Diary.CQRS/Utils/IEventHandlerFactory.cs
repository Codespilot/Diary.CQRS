using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Diary.CQRS.EventHandlers;
using Diary.CQRS.Events;

namespace Diary.CQRS.Utils
{
    public interface IEventHandlerFactory
    {
        IEnumerable<IEventHandler<T>> GetHandlers<T>() where T : Event;
    }
}

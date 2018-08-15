using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Diary.CQRS.Domain;
using Diary.CQRS.Domain.Mementos;
using Diary.CQRS.Events;

namespace Diary.CQRS.Storage
{
    public interface IEventStorage
    {
        IEnumerable<Event> GetEvents(Guid aggregateId);
        void Save(AggregateRoot aggregate);
        T GetMemento<T>(Guid aggregateId) where T: BaseMemento;
        void SaveMemento(BaseMemento memento);
    }
}

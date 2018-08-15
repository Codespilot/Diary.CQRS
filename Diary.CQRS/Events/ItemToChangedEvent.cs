using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diary.CQRS.Events
{
    public class ItemToChangedEvent : Event
    {
        public DateTime To { get; internal set; }
        public ItemToChangedEvent(Guid aggregateId, DateTime to)
        {
			AggregateId = aggregateId;
            To = to;
        }
    }
}

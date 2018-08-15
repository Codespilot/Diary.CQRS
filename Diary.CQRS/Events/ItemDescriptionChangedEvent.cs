using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diary.CQRS.Events
{
    public class ItemDescriptionChangedEvent : Event
    {
        public string Description { get; internal set; }
        public ItemDescriptionChangedEvent(Guid aggregateId, string description)
        {
			AggregateId = aggregateId;
            Description = description;
        }
    }
}

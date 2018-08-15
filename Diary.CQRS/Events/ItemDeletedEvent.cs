using System;

namespace Diary.CQRS.Events
{
    public class ItemDeletedEvent:Event
    {
        public ItemDeletedEvent(Guid aggregateId)
        {
			AggregateId = aggregateId;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Diary.CQRS.Events
{
    public interface IEvent
    {
        Guid Id { get; }
    }
}

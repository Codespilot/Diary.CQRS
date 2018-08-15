﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Diary.CQRS.Events;
using Diary.CQRS.Reporting;

namespace Diary.CQRS.EventHandlers
{
    public class ItemRenamedEventHandler : IEventHandler<ItemRenamedEvent>
    {
        private readonly IReportDatabase _reportDatabase;
        public ItemRenamedEventHandler(IReportDatabase reportDatabase)
        {
            _reportDatabase = reportDatabase;
        }
        public void Handle(ItemRenamedEvent handle)
        {
            var item = _reportDatabase.GetById(handle.AggregateId);
            item.Title = handle.Title;
            item.Version = handle.Version;
        }
    }
}

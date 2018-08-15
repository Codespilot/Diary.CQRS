using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Diary.CQRS.CommandHandlers;
using Diary.CQRS.Commands;

namespace Diary.CQRS.Utils
{
    public interface ICommandHandlerFactory
    {
        ICommandHandler<T> GetHandler<T>() where T : Command;
    }
}

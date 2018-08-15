using System;
using Diary.CQRS.Commands;

namespace Diary.CQRS.Messaging
{
    public interface ICommandBus
    {
        void Send<T>(T command) where T : Command;
    }
}

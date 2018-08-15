using System;

namespace Diary.CQRS.Commands
{
    public interface ICommand
    {
        Guid Id { get; }
    }
}

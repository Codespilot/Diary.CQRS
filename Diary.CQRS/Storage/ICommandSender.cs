using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DiaryCQRS.Commands;

namespace DiaryCQRS.Storage
{
    public interface ICommandSender
    {
        void Send<T>(T command) where T : Command;
    }
}

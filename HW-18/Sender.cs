using System;
using System.Collections.Generic;
using System.Text;

namespace HW_18
{/// <summary>
/// отправитель команды
/// </summary>
    class Sender
    {
        ICommand command;
        public void SetCommand(ICommand command)
        {
            this.command = command;
        }
        public void Run()
        {
            command.RunAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace HW_18
{/// <summary>
/// базовый класс команды
/// </summary>
    public interface  ICommand
    {
        public void RunAsync();
    }
}

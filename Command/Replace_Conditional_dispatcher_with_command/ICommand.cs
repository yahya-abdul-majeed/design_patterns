using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Replace_Conditional_dispatcher_with_command
{
    internal interface ICommand
    {
        void Execute(string command);
    }
}

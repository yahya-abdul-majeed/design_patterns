using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Command_Pattern_with_receiver_object
{
    internal class Invoker
    {
        private readonly ConcreteCommand1 _command1;
        private readonly ConcreteCommand2 _command2;

        public Invoker(ConcreteCommand1 command1, ConcreteCommand2 command2)
        {
            _command1 = command1;
            _command2 = command2;
        }

        public void onClick(string click)
        {
            if (click == "long_click")
                _command1.Execute();
            if (click == "double_click")
                _command2.Execute();
        }
    }
}

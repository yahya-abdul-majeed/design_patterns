using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Command_Pattern_with_receiver_object
{
    internal class ConcreteCommand1 : CommandBase
    {
        public ConcreteCommand1(Receiver receiver):base(receiver) { }
        public override void Execute()
        {
            _receiver.doSomethingForCommand1();
        }
    }
}

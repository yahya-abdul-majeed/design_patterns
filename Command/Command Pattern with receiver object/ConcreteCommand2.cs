using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Command_Pattern_with_receiver_object
{
    internal class ConcreteCommand2 : CommandBase
    {
        public ConcreteCommand2(Receiver receiver):base(receiver){}
        
        public override void Execute()
        {
            _receiver.doSomethingForCommand2();
        }
    }
}

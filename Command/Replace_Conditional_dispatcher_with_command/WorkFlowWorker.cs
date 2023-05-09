using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command.Replace_Conditional_dispatcher_with_command
{
    internal class WorkFlowWorker // the Invoker class
    {
        private readonly ICommand _workflowExecutionTerminationCommand;
        private readonly ICommand _workflowExecutionDetailsCommand;
        private Dictionary<string, ICommand> _map;

        public WorkFlowWorker(ICommand workflowExecutionTerminationCommand, ICommand workflowExecutionDetailsCommand)
        {
            _workflowExecutionTerminationCommand = workflowExecutionTerminationCommand;
            _workflowExecutionDetailsCommand = workflowExecutionDetailsCommand;
            _map = new Dictionary<string, ICommand>();
            _map.Add("workflow_execution_terminaton_queue", _workflowExecutionTerminationCommand);
            _map.Add("workflow_execution_details_queue",_workflowExecutionDetailsCommand);
        }

        public void onMessage(string queue, string message)//receies a message from a queue
        {
            if (_map.ContainsKey(queue))
            {
                _map[queue].Execute(message);
            }
            else
            {
                throw new Exception("queue not found");
            }
        }
    }
}

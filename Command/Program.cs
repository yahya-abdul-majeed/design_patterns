//Command Pattern - Behavioral
//converts requests or simple operations into objects

//if operation is simple enough, we don't need the receiver class. the command can itself execute the operation


using Command.Command_Pattern_with_receiver_object;
using Command.Replace_Conditional_dispatcher_with_command;

//WorkflowExecutionTerminationCommand termination_command = new();
//WorkflowExecutionDetailsCommand details_command = new();

//WorkFlowWorker wfw = new(termination_command, details_command);

//wfw.onMessage("workflow_execution_details_queue", "hey there");

Receiver receiver = new();
ConcreteCommand1 command1 = new ConcreteCommand1(receiver);
ConcreteCommand2 command2 = new ConcreteCommand2(receiver);

Invoker inv = new(command1, command2);

inv.onClick("double_click");
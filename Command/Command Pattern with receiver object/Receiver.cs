namespace Command.Command_Pattern_with_receiver_object
{
    internal class Receiver
    {
        public void doSomethingForCommand1()
        {
            Console.WriteLine("doSomethingForCommand1");
        }
        public void doSomethingForCommand2() {
            Console.WriteLine("doSomethingForCommand2");
        }
    }
}
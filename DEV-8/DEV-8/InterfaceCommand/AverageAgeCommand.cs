using System;

namespace DEV_8
{
    /// <summary>
    /// Does average age command.
    /// </summary>
    class AverageAgeCommand : ICommand
    {
        CommandReceiver receiver = new CommandReceiver();

        /// <summary>
        /// Implements Interface member Execute to average age command.
        /// </summary>
        public void Execute()
        {
            Console.WriteLine($"Average age: {receiver.AverageAge()}");
        }
    }
}

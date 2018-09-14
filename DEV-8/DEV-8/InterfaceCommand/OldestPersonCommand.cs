using System;

namespace DEV_8
{
    /// <summary>
    /// Does oldest person command.
    /// </summary>
    class OldestPersonCommand : ICommand
    {
        CommandReceiver receiver = new CommandReceiver();

        /// <summary>
        /// Implements Interface member Execute to oldest person command.
        /// </summary>
        void ICommand.Execute()
        {
            Console.WriteLine("The oldest person in list: ");
            receiver.OldestPerson().OutputPerson();
        }
    }
}

namespace DEV_7
{
    /// <summary>
    /// Does 'check storehouse' command.
    /// </summary>
    class CheckStorehouseAction : ICommand
    {
        CommandReceiver receiver = new CommandReceiver();

        /// <summary>
        /// Implements Interface member Execute to 'check storehouse' command. 
        /// </summary>
        public void Execute()
        {
            receiver.CheckStorehouse();
        }
    }
}

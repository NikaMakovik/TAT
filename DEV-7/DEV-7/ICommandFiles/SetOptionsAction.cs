namespace DEV_7
{
    /// <summary>
    /// Does 'add options' command.
    /// </summary>
    class SetOptionsAction : ICommand
    {
        CommandReceiver receiver = new CommandReceiver();

        /// <summary>
        /// Implements Interface member Execute to 'add options' command. 
        /// </summary>
        public void Execute()
        {
            receiver.SetOptions();
        }
    }
}

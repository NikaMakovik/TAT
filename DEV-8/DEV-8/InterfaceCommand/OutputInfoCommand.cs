namespace DEV_8
{
    /// <summary>
    /// Does 'info' command.
    /// </summary>
    class OutputInfoCommand : ICommand
    {
        CommandReceiver receiver = new CommandReceiver();

        /// <summary>
        /// Implements Interface member Execute to 'info' command.
        /// </summary>
        public void Execute()
        {
            receiver.OutputInfo();
        }
    }
}

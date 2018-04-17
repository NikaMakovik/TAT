namespace DEV_8
{
    /// <summary>
    /// Does user menu command.
    /// </summary>
    class UserMenuCommand : ICommand
    {
        CommandReceiver receiver = new CommandReceiver();

        /// <summary>
        /// Implements Interface member Execute to user menu command.
        /// </summary>
        public void Execute()
        {
            receiver.UserMenu();
        }
    }
}

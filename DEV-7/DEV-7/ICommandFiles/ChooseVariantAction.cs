namespace DEV_7
{
    /// <summary>
    /// Does 'choose variant' option.
    /// </summary>
    class ChooseVariantAction : ICommand
    {
        CommandReceiver receiver = new CommandReceiver();
        Options options = new Options();

        public ChooseVariantAction(Options options)
        {
            this.options = options;
        }
        /// <summary>
        /// Implements Interface member Execute to 'choose variant' command. 
        /// </summary>
        public void Execute()
        {
            receiver.ChooseVariant(options);
        }
    }
}

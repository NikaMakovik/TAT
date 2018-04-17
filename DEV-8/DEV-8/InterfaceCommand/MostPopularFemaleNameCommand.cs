using System;

namespace DEV_8
{
    /// <summary>
    /// Does most popular female name command.
    /// </summary>
    class MostPopularFemaleNameCommand : ICommand
    {
        CommandReceiver receiver = new CommandReceiver();

        /// <summary>
        /// Implements Interface member Execute to most popular female name command.
        /// </summary>
        public void Execute()
        {
            Console.WriteLine($"The most popular female name is: {receiver.MostPopularFemaleName()}");            
        }
    }
}

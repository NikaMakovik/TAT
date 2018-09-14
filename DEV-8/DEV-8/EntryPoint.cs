using System;

namespace DEV_8
{
    class EntryPoint
    {
        static void Main(string[] args)
        {            
            CommandInvoker commandInvoker = new CommandInvoker();

            try
            {
                commandInvoker.SetCommand(new UserMenuCommand());
                commandInvoker.Run();
            }
            catch (UndefinedSexException exception)
            {
                Console.WriteLine(exception.Message);
                commandInvoker.SetCommand(new AddPersonCommand());
                commandInvoker.Run();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);

            }
        }
    }
}

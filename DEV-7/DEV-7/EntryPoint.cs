using System;

namespace DEV_7
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            try
            {
                menu.UsersActionsMenu();
            }
            catch (Exception exception)
            {
                Console.WriteLine(exception.Message);
            }
        }
    }
}

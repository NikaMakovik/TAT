using System;

namespace DEV_8
{
    /// <summary>
    /// Event SameLastNamesHappened arguments.
    /// </summary>
    public class SameLastNamesHappenedEventArgs : EventArgs
    {
        public string LastName { get; set; }
    }
}

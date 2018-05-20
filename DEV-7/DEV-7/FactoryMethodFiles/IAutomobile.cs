namespace DEV_7
{
    abstract public class IAutomobile
    {
        Options AutoProperties;
        public IAutomobile(Options options)
        {
            AutoProperties = options;
        }
        abstract public Options SetProperties();
    }
}

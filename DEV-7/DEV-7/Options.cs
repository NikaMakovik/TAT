using System;

namespace DEV_7
{
    /// <summary>
    /// Class-container, has options as fields.
    /// </summary>
    public class Options
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public string CarcaseType { get; set; }
        public string TransmissionType { get; set; }
        public string EngineType { get; set; }
        public string EngineSize { get; set; }
        public string EnginePower { get; set; }
        public string ClimateControle { get; set; }
        public string CabinType { get; set; }

        /// <summary>
        /// Output options.
        /// </summary>
        public void OutputOptions()
        {
            Console.WriteLine(Brand);
            Console.WriteLine(Model);
            Console.WriteLine(CarcaseType);
            Console.WriteLine(TransmissionType);
            Console.WriteLine(EngineType);
            Console.WriteLine(EngineSize);
            Console.WriteLine(EnginePower);
            Console.WriteLine(ClimateControle);
            Console.WriteLine(CabinType);
            Console.WriteLine();
        }
    }
}

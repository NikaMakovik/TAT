using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace DEV_7
{
    class CommandReceiver
    {
        JSONSerializer jsonSerializer = new JSONSerializer();
        CommandInvoker commandInvoker = new CommandInvoker();

        public void SetOptions()
        {
            Console.WriteLine("If you don't want to set parameter, enter '-'.");
            Options options = new Options();

            Console.Write("Enter brand: ");
            string newBrand = Console.ReadLine();
            options.Brand = newBrand;

            Console.Write("Enter model: ");
            string newModel = Console.ReadLine();
            options.Model = newModel;

            Console.Write("Enter carcase type: ");
            string newCarcaseType = Console.ReadLine();
            options.CarcaseType = newCarcaseType;

            Console.Write("Enter transmission type: ");
            string newTransmissionType = Console.ReadLine();
            options.TransmissionType = newTransmissionType;

            Console.Write("Enter engine type: ");
            string newEngineType = Console.ReadLine();
            options.EngineType = newEngineType;

            Console.Write("Enter engine size: ");
            string newEngineSize = Console.ReadLine();
            options.EngineSize = newEngineSize;

            Console.Write("Enter engine power: ");
            string newEnginePower = Console.ReadLine();
            options.EnginePower = newEnginePower;

            Console.Write("Enter climate controle: ");
            string newClimateControle = Console.ReadLine();
            options.ClimateControle = newClimateControle;

            Console.Write("Enter cabin type: ");
            string newCabinType = Console.ReadLine();
            options.CabinType = newCabinType;

            commandInvoker.SetCommand(new ChooseVariantAction(options));
        }
        public void ChooseVariant(Options options)
        {
            List<Options> selectedVariants = (List<Options>)CheckCatalog(options);
            for (int i = 0; i < selectedVariants.Capacity; i++)
            {
                Console.WriteLine($"Select {i + 1} to choose this variant.");
                selectedVariants[i].OutputOptions();
            }
            int key = int.Parse(Console.ReadLine());
            ProduceAuto(selectedVariants[key--]);
        }
        public void CheckStorehouse()
        { }

        private void ProduceAuto(Options optionToProduceAutomobile)
        {
            TeslaCreator teslaCreator = new TeslaCreator();
            BMWCreator bmwCreator = new BMWCreator();
            switch (optionToProduceAutomobile.Brand)
            {
                case "BMW X5":
                    IAutomobile newTeslaCar = teslaCreator.CreateAuto(optionToProduceAutomobile);
                    
                    break;
                case "Tesla":
                    IAutomobile newBMWCar = bmwCreator.CreateAuto(optionToProduceAutomobile);
                    
                    break;
            }
            Console.WriteLine("Your automobile is waiting in the storehouse.");
        }
        private IEnumerable<Options> CheckCatalog(Options options)
        {
            JSONDeserializer jsonDeserializer = new JSONDeserializer(File.ReadAllText(@"D:\Workspace\TAT\DEV-7\DEV-7\catalog.json"));
            List<Options> catalog = jsonDeserializer.GetDeserializedOptions();
            var selectedVariants = from item in catalog
                                   where ((item.Brand == options.Brand || item.Brand == "-") &&
                                   (item.Model == options.Model || item.Model == "-") &&
                                   (item.CarcaseType == options.CarcaseType || item.Model == "-") &&
                                   (item.TransmissionType == options.TransmissionType || item.Model == "-") &&
                                   (item.EngineType == options.EngineType || item.Model == "-") &&
                                   (item.EngineSize == options.EngineSize || item.Model == "-") &&
                                   (item.EnginePower == options.EnginePower || item.Model == "-") &&
                                   (item.ClimateControle == options.ClimateControle || item.Model == "-") &&
                                   (item.CabinType == options.CabinType || item.Model == "-"))
                                   select item;
            return selectedVariants;
        }
    }
}

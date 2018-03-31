using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DEV_7
{
    class TeslaCreator : IAutoCreator
    {
        public IAutomobile CreateAuto(Options options)
        {
            return new TeslaAuto(options);
        }
    }
}

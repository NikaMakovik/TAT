using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DEV_7
{
    class TeslaAuto : IAutomobile
    {
        Options options;
        public TeslaAuto(Options options)
        {
            this.options = options;
        }
    }
}

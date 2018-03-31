using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DEV_7
{
    class BMWAuto : IAutomobile
    {
        Options options;
        public BMWAuto (Options options)
        {
            this.options = options;
        }
    }
}

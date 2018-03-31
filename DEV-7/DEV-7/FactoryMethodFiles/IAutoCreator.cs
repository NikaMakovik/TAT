using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DEV_7
{
    interface IAutoCreator
    {
        IAutomobile CreateAuto(Options options);
    }
}

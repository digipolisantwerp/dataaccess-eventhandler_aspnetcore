﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Digipolis.Toolbox.DataAccess.EventHandler
{
    internal class ChangedProperty
    {
        public string Name;
        public object CurrentValue;
        public object OriginalValue;
    }
}
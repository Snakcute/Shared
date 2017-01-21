using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snakcute.Shared
{
    public abstract class ActionBase
    {
        public string Token { get; set; }

        public DateTimeOffset Time { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snakcute.Shared
{
    public class AttackAction : ActionBase
    {
        public string TargetToken { get; set; }

        public int Damage { get; set; }
    }
}

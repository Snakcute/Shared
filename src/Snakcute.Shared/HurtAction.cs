using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snakcute.Shared
{
    public class HurtAction : ActionBase
    {
        public string AttackerToken { get; set; }

        public int Damage { get; set; }

        public int HP { get; set; }
    }
}

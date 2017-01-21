using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snakcute.Shared
{
    public class BattleUnit
    {
        public string Token { get; set; }

        public UnitType Type { get; set; }

        public UnitTeam Team { get; set; }

        public long ModelId { get; set; }

        public short? SnakeId { get; set; }

        public double Speed { get; set; }

        public double Accelerate { get; set; }
    }
}

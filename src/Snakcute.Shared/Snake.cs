using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Snakcute.Shared
{
    public class Snake
    {
        public short Id { get; set; }

        public int ModelId { get; set; }

        public JsonObject<List<int>> Spells { get; set; } = "[]";

        public double Speed { get; set; }

        public double Accelerate { get; set; }

        public int MaxLength { get; set; }

        public int PriceCoin { get; set; }

        public int PriceCash { get; set; }
    }
}

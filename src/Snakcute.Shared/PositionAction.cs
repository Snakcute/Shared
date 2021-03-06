﻿using System.Collections.Generic;

namespace Snakcute.Shared
{
    public class PositionAction : ActionBase
    {
        public double X { get; set; }

        public double Y { get; set; }

        public double Angle { get; set; }

        public double LinearVelocity { get; set; }

        public double AngularVelocity { get; set; }

        public List<TailLog> Tails { get; set; } = new List<TailLog>();
    }
}

using System;

namespace Snakcute.Shared
{
    public abstract class ActionBase
    {
        public string Token { get; set; }

        public DateTimeOffset Time { get; set; }
    }
}

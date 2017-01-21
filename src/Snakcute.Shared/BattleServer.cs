using System;

namespace Snakcute.Shared
{
    public class BattleServer
    {
        public Guid Id { get; set; }

        public string IP { get; set; }

        public int Port { get; set; }

        public string Token { get; set; }

        public int MaxUser { get; set; }

        public int CurrentUser { get; set; }

        public int CurrentBattle { get; set; }
    }
}

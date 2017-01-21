using System;
using System.Collections.Generic;

namespace Snakcute.Shared
{
    public class Battle
    {
        public Guid Id { get; set; }

        public virtual ICollection<UserBattleLog> UserBattleLogs { get; set; } = new List<UserBattleLog>();

        public JsonObject<List<Guid>> BlueTeam { get; set; } = "[]";

        public JsonObject<List<Guid>> RedTeam { get; set; } = "[]";

        public DateTime BeginTime { get; set; }

        public DateTime EndTime { get; set; }

        public BattleType Type { get; set; }

        public JsonObject<List<BattleUnit>> Units { get; set; } = "[]";

        public JsonObject<List<ActionBase>> Actions { get; set; } = "[]";
    }
}

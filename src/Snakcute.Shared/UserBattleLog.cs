using System;
namespace Snakcute.Shared
{
    public class UserBattleLog
    {
        public Guid Id { get; set; }

        public Guid UserId { get; set; }

        public virtual User User { get; set; }

        public BattleResult Result { get; set; }

        public long MMRDiversification { get; set; }

        public Guid BattleId { get; set; }

        public virtual Battle Battle { get; set; }
    }
}

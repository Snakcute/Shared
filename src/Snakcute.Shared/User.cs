using System;
using System.Collections.Generic;
#if !NET35
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
#endif

namespace Snakcute.Shared
{
    public class User
    {
        public Guid Id { get; set; }

        public DateTime RegisterDate { get; set; } = DateTime.Now;

        public DateTime? LastLoginDate { get; set; } = DateTime.Now;

        public UserRole Role { get; set; }

        public UserStatus Status { get; set; }
#if !NET35
        [MaxLength(64)]
#endif
        public string NickName { get; set; }

        public string OpenId { get; set; }

        public SocialType Social { get; set; }

        public long Coin { get; set; }

        public long MMR { get; set; }
#if !NET35
        [MaxLength(64)]
#endif
        public string Token { get; set; }

        public int Level { get; set; } = 1;

        public int Experience { get; set; } = 0;

        public virtual ICollection<UserBattleLog> BattleLogs { get; set; } = new List<UserBattleLog>();
    }
}

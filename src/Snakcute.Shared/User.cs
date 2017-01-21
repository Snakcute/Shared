using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Snakcute.Shared
{
    public class User
    {
        public Guid Id { get; set; }

        public DateTime RegisterDate { get; set; } = DateTime.Now;

        public DateTime? LastLoginDate { get; set; } = DateTime.Now;

        public UserRole Role { get; set; }

        public UserStatus Status { get; set; }

        [MaxLength(64)]
        public string NickName { get; set; }

        public string OpenId { get; set; }

        public SocialType Social { get; set; }

        public long Coin { get; set; }

        public long MMR { get; set; }

        [MaxLength(64)]
        public string Token { get; set; }

        public int Level { get; set; } = 1;

        public int Experience { get; set; } = 0;

        public virtual ICollection<UserBattleLog> BattleLogs { get; set; } = new List<UserBattleLog>();
    }
}

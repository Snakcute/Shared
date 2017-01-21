using System;
#if !NET35
using System.ComponentModel.DataAnnotations.Schema;
#endif

namespace Snakcute.Shared
{
    public class UserRelation
    {
#if !NET35
        [ForeignKey("User")]
#endif
        public Guid UserId { get; set; }

        public virtual User User { get; set; }

#if !NET35
        [ForeignKey("TargetUser")]
#endif
        public Guid TargetUserId { get; set; }

        public virtual User TargetUser { get; set; }

        public UserRelationStatus Status { get; set; }

        public DateTime LastUpdateTime { get; set; }
    }
}

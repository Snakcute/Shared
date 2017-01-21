using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;

namespace Snakcute.Shared
{
    public class UserRelation
    {
        [ForeignKey("User")]
        public Guid UserId { get; set; }

        public virtual User User { get; set; }

        [ForeignKey("TargetUser")]
        public Guid TargetUserId { get; set; }

        public virtual User TargetUser { get; set; }

        public UserRelationStatus Status { get; set; }

        public DateTime LastUpdateTime { get; set; }
    }
}

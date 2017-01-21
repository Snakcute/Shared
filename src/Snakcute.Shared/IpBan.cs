using System;
using System.ComponentModel.DataAnnotations;

namespace Snakcute.Shared
{
    public class IpBan
    {
#if !NET35
        [MaxLength(64)]
#endif
        public string IP { get; set; }

        public DateTime Unban { get; set; }
    }
}

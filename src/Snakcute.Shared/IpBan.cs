using System;
using System.ComponentModel.DataAnnotations;

namespace Snakcute.Shared
{
    public class IpBan
    {
        [MaxLength(64)]
        public string IP { get; set; }

        public DateTime Unban { get; set; }
    }
}

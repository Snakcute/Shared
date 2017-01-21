using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Snakcute.Shared
{
    public class SnakcuteContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public DbSet<Battle> Battles { get; set; }

        public DbSet<Snake> Snakes { get; set; }

        public DbSet<BattleServer> BattleServers { get; set; }

        public DbSet<RealmServer> RealmServers { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<User>(e =>
            {
                e.HasIndex(x => x.MMR);
                e.HasIndex(x => x.Level);
                e.HasIndex(x => x.Role);
                e.HasIndex(x => x.Social);
                e.HasIndex(x => x.Token).IsUnique();
                e.HasIndex(x => x.NickName).IsUnique();
            });

            builder.Entity<Battle>(e =>
            {
                e.HasIndex(x => x.BeginTime);
                e.HasIndex(x => x.EndTime);
                e.HasIndex(x => x.Type);
            });
        }
    }
}

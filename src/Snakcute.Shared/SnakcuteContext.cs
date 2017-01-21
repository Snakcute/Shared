#if !NET35
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Snakcute.Shared
{
    public class SnakcuteContext : DbContext
    {
        private string _connectionString;

        public SnakcuteContext(string connectionString) : base()
        {
            _connectionString = connectionString;
        }

        public DbSet<User> Users { get; set; }

        public DbSet<UserRelation> UserRelations { get; set; }

        public DbSet<Battle> Battles { get; set; }

        public DbSet<Snake> Snakes { get; set; }

        public DbSet<BattleServer> BattleServers { get; set; }

        public DbSet<RealmServer> RealmServers { get; set; }

        public DbSet<IpBan> IpBans { get; set; }

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

            builder.Entity<UserRelation>(e =>
            {
                e.HasKey(x => new { x.UserId, x.TargetUserId });
                e.HasIndex(x => x.Status);
            });

            builder.Entity<Battle>(e =>
            {
                e.HasIndex(x => x.BeginTime);
                e.HasIndex(x => x.EndTime);
                e.HasIndex(x => x.Type);
            });

            builder.Entity<BattleServer>(e =>
            {
                e.HasIndex(x => x.MaxUser);
                e.HasIndex(x => x.CurrentUser);
            });

            builder.Entity<RealmServer>(e =>
            {
                e.HasIndex(x => x.MaxUser);
                e.HasIndex(x => x.CurrentUser);
            });

            builder.Entity<IpBan>(e =>
            {
                e.HasIndex(x => x.Unban);
            });
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseMySql(_connectionString);
        }
    }
}
#endif
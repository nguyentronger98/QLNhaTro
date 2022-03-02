using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Text;
using System.Data.Entity;
using System.Threading.Tasks;

namespace ModelEF.EF
{
    public partial class QLPhongTroDbContext: DbContext
    {
        public QLPhongTroDbContext()
            : base("name=QLPhongTroDbContext")
        {
        }

        public virtual DbSet<khaibaonhankhau> khaibaonhankhaus { get; set; }
        //public virtual DbSet<Role> Roles { get; set; }
        //public virtual DbSet<UserGroup> UserGroups { get; set; }
        //public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<khaibaonhankhau>()
                .Property(e => e.MA)
                .IsUnicode(false);
        }
    }
}

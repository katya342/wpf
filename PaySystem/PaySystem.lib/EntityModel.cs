using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;
using System.Security.Policy;

namespace PaySystem.lib
{
    public partial class EntityModel : DbContext
    {
        public EntityModel()
            : base("name=EntityModel")
        {
        }

        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Operators> Operators { get; set; } 
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Linq;

namespace BookStore.lib
{
    public partial class EntityModel : DbContext
    {
        public EntityModel()
            : base("name=EntityModel")
        {
        }

        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Book> Book { get; set; }
        public virtual DbSet<SubCategory> SubCategory { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

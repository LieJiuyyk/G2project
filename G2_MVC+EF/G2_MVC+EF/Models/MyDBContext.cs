namespace G2_MVC_EF.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MyDBContext : DbContext
    {
        public MyDBContext()
            : base("name=MyDBContext")
        {
        }

        public virtual DbSet<Brand> Brand { get; set; }
        public virtual DbSet<BuyCar> BuyCar { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<Comment> Comment { get; set; }
        public virtual DbSet<Commodity> Commodity { get; set; }
        public virtual DbSet<Orders> Orders { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<User> User { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<BuyCar>()
                .Property(e => e.Bprice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Commodity>()
                .Property(e => e.Cprice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Orders>()
                .Property(e => e.Bprice)
                .HasPrecision(19, 4);

            modelBuilder.Entity<Orders>()
                .Property(e => e.zhifuTyPe)
                .IsFixedLength();
        }
    }
}

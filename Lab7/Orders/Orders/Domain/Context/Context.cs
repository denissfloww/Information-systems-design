namespace Orders.Domain.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Context : DbContext
    {
        public Context()
            : base("name=Context")
        {
        }

        public virtual DbSet<Notification> Notifications { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<Organization> Organizations { get; set; }
        public virtual DbSet<Plan> Plans { get; set; }
        public virtual DbSet<Role> Roles { get; set; }
        public virtual DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Organization>()
                .HasMany(e => e.Plans)
                .WithRequired(e => e.Organizations)
                .HasForeignKey(e => e.ClientId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Organization>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Organizations)
                .HasForeignKey(e => e.OrganizationId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Plan>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Plans)
                .HasForeignKey(e => e.PlanId);

            modelBuilder.Entity<Role>()
                .Property(e => e.RoleName)
                .IsFixedLength();

            modelBuilder.Entity<Role>()
                .HasMany(e => e.Users)
                .WithRequired(e => e.Roles)
                .HasForeignKey(e => e.RoleId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<User>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.SecondName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.MiddleName)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Username)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .Property(e => e.Password)
                .IsUnicode(false);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Notifications)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);

            modelBuilder.Entity<User>()
                .HasMany(e => e.Orders)
                .WithOptional(e => e.Users)
                .HasForeignKey(e => e.UserId);
        }
    }
}

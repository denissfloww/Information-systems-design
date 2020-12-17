namespace Orders.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Users")]
    public partial class User
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public User()
        {
            Notifications = new HashSet<Notification>();
            Orders = new HashSet<Order>();
        }

        [Column("Id", TypeName = "int")]
        public int Id { get; set; }

        [Column("first_name", TypeName = "nvarchar")]
        [Required]
        public string FirstName { get; set; }

        [Column("second_name", TypeName = "nvarchar")]
        [Required]
        public string SecondName { get; set; }

        [Column("middle_name", TypeName = "nvarchar")]
        [Required]
        public string MiddleName { get; set; }

        [Column("org_id", TypeName = "int")]
        public int OrganizationId { get; set; }

        [Column("username", TypeName = "nvarchar")]
        [Required]
        public string Username { get; set; }

        [Column("password", TypeName = "nvarchar")]
        [Required]
        public string Password { get; set; }

        [Column("role", TypeName = "int")]
        public int RoleId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Notification> Notifications { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }

        public virtual Organization Organizations { get; set; }

        public virtual Role Roles { get; set; }
    }
}

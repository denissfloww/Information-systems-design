namespace Orders.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Organizations")]
    public partial class Organization
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Organization()
        {
            Plans = new HashSet<Plan>();
            Users = new HashSet<User>();
        }

        [Column("id", TypeName = "int")]
        public int Id { get; set; }

        [Column("name", TypeName = "nvarchar")]
        public string Name { get; set; }

        [Column("address", TypeName = "nvarchar")]
        public string Address { get; set; }

        [Column("tel", TypeName = "nvarchar")]
        [StringLength(50)]
        public string Number { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Plan> Plans { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<User> Users { get; set; }
    }
}

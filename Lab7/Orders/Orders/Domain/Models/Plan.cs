namespace Orders.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Plans")]
    public partial class Plan
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Plan()
        {
            Orders = new HashSet<Order>();
        }

        [Column("id", TypeName = "int")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [Column("place", TypeName = "nvarchar")]
        public string Place { get; set; }

        [Column("date", TypeName = "datetime")]
        public DateTime? Date { get; set; }

        [Column("client_org_id", TypeName = "int")]
        public int ClientId { get; set; }

        [Column("order_id", TypeName = "int")]
        public int? OrderId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Order> Orders { get; set; }

        public virtual Organization Organizations { get; set; }
    }
}

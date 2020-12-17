namespace Orders.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Notifications")]
    public partial class Notification
    {
        [Column("id", TypeName = "int")]
        public int Id { get; set; }

        [Column("content", TypeName = "nvarchar")]
        [Required]
        public string Content { get; set; }

        [Column("type", TypeName = "nvarchar")]
        [StringLength(50)]
        public string Type { get; set; }

        [Column("date", TypeName = "datetime")]
        public DateTime? Date { get; set; }

        [Column("user_id", TypeName = "int")]
        public int? UserId { get; set; }

        public virtual User Users { get; set; }
    }
}

namespace Orders.Domain.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Orders")]
    public partial class Order
    {
        [Key]
        [Column("id", TypeName = "int")]
        public int Id { get; set; }

        [Column("user_id", TypeName = "int")]
        public int? UserId { get; set; }

        [Column("date_create", TypeName = "datetime")]
        public DateTime? DateCreate { get; set; }

        [Column("cath_goal", TypeName = "nvarchar")]
        [StringLength(50)]
        public string CatchGoal { get; set; }

        [Column("scan", TypeName = "nvarchar")]
        public string Scan { get; set; }

        [Column("plan_id", TypeName = "int")]
        public int? PlanId { get; set; }

        public virtual Plan Plans { get; set; }

        public virtual User Users { get; set; }

        public int NumMK { get => (int)Math.Pow(Id + 10, 2) % 307; }

        public DateTime DateMK { get => DateCreate.Value.Subtract(TimeSpan.FromDays(NumMK % 30)); }
    }
}

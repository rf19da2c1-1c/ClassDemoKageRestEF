namespace ClassDemoKageRestEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KagerForEn")]
    public partial class KagerForEn
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(30)]
        public string Name { get; set; }

        [Key]
        [Column(Order = 1)]
        public double Price { get; set; }

        [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int NoOfPieces { get; set; }

        [Key]
        [Column(Order = 3)]
        public int Id { get; set; }
    }
}

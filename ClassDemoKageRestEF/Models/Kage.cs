namespace ClassDemoKageRestEF.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Kage")]
    public partial class Kage
    {
        [Required]
        [StringLength(30)]
        public string Name { get; set; }

        public double Price { get; set; }

        public int NoOfPieces { get; set; }

        public int Id { get; set; }
    }
}

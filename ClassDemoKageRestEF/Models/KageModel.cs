namespace ClassDemoKageRestEF.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class KageModel : DbContext
    {
        public KageModel()
            : base("name=KageModel")
        {
        }

        public virtual DbSet<Kage> Kages { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Kage>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}

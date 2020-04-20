namespace ClassDemoKageRestEF.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NyKageModel : DbContext
    {
        public NyKageModel()
            : base("name=KageModel")
        {
        }

        public virtual DbSet<KagerForEn> KagerForEns { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KagerForEn>()
                .Property(e => e.Name)
                .IsUnicode(false);
        }
    }
}

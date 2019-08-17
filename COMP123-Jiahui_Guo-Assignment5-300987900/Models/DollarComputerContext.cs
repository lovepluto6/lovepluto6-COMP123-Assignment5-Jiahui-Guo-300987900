namespace COMP123_Jiahui_Guo_Assignment5_300987900.Sql
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class DollarComputerContext : DbContext
    {
        public DollarComputerContext()
            : base("name=DollarComputerConnection")
        {
        }

        public virtual DbSet<products> products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<products>()
                .Property(e => e.cost)
                .HasPrecision(19, 4);
        }
    }
}

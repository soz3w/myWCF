namespace ServerWCF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelData : DbContext
    {
        public ModelData()
            : base("name=ModelData")
        {
        }

        public virtual DbSet<Artists> Artists { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

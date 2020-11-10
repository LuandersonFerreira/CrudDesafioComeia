namespace DesafioCrudMvcComeia.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;

    public partial class DbModels : DbContext
    {
        public DbModels()
            : base("name=DbModels")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {

           // throw new UnintentionalCodeFirstException();
        }

        public virtual DbSet<Empresas> Empresas { get; set; }
    }

}
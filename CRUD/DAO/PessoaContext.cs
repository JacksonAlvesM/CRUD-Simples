using CRUD.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace CRUD.DAL
{
    public class PessoaContext : DbContext
    {

        public PessoaContext() : base("PessoaContext")
        {
        }
        public DbSet<Pessoa> pessoas { get; set; }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
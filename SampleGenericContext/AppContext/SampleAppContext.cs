using DataAccessRepository.Context;
using Microsoft.EntityFrameworkCore;
using SampleGenericContext.Entities;

namespace SampleGenericContext.AppContext
{
    public class SampleAppContext : EntityContextBase<SampleAppContext>
    {
        public SampleAppContext(DbContextOptions<SampleAppContext> options) : base(options)
        { }

        public DbSet<Person> Person { get; set; }
        public DbSet<PersonAddress> PersonAddress { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.LowerCase();
        }
    }
}
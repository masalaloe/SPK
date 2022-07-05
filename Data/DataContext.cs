using Microsoft.EntityFrameworkCore;
using SPK.Models;

namespace SPK.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base (options)
        {

        }

        public DbSet<Disease> Diseases { get; set; }
        public DbSet<Solution> Solutions { get; set; }
        public DbSet<Symptom> Symptoms { get; set; }
    }
}

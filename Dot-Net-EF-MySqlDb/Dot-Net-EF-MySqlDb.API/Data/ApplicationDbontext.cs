using Dot_Net_EF_MySqlDb.API.Models.Domain;
using Microsoft.EntityFrameworkCore;
using System.Configuration;

namespace Dot_Net_EF_MySqlDb.API.Models
{
    public class ApplicationDbontext : DbContext
    {

        public ApplicationDbontext()
        {
            
        }

        public ApplicationDbontext(DbContextOptions<ApplicationDbontext> options) : base(options)
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            //IConfigurationRoot configuration = new ConfigurationBuilder().SetBasePath(Directory.GetCurrentDirectory()).AddJsonFile("appsettings.json").Build();
            //var connectionString = configuration.GetConnectionString("MysqlDbConnectionString");
            //optionsBuilder.UseMySql(connectionString,ServerVersion.AutoDetect(connectionString));
        }

        public DbSet<Region> Region {  get; set; }

        public DbSet<Difficulty> Difficulty { get; set; }

        public DbSet<Walk> Walk {  get; set; }

        public DbSet<Product> Product {  get; set; }

    }
}

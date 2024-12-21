using ComputerCenterServer.Configuration;
using ComputerCenterServer.Models;
using Microsoft.EntityFrameworkCore;


namespace ComputerCenterServer.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<Customer> Customers { get; set; }

    public DbSet<Order> Orders { get; set; }

    public DbSet<PurchasedProduct> PurchasedProducts { get; set; }

    public DbSet<Product> Products { get; set; }

    public DbSet<PurchasedServices> PurchasedServices { get; set; }

    public DbSet<Services> Services { get; set; }

    public DbSet<Manufacture> Manufactures { get; set; }

    public DbSet<Provider> Providers { get; set; }

    public DbSet<Admin> Admins { get; set; }    

    public DbSet<Person> Persons { get; set; } 


    //настройка строки подключения
    protected override void OnConfiguring(DbContextOptionsBuilder options)
    {
        options.EnableSensitiveDataLogging();
        var connectionString = "server=localhost;port=3306;database=ComputerCenter;user id=root;password=BuildSQLData;";

        options.UseMySql(connectionString, ServerVersion.AutoDetect(connectionString));
    }


    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new PurchasedProductConfiguration());
        modelBuilder.ApplyConfiguration(new PurchasedServicesConfiguration());
        modelBuilder.ApplyConfiguration(new InitDBPerson());
        modelBuilder.ApplyConfiguration(new InitDBAdmin());



        base.OnModelCreating(modelBuilder);
    }

}

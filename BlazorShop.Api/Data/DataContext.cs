using Microsoft.EntityFrameworkCore;

public class DataContext : DbContext
{
    public DataContext(DbContextOptions<DataContext> options) : base(options)
    {

    }
    public DbSet<Product>? Products { get; set; }
    public DbSet<Category>? Categories { get; set; }
    public DbSet<Cart>? Carts { get; set; }
    public DbSet<CartItem>? CartItems { get; set; }
    public DbSet<User>? Users { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Category>().HasData(new Category
        {
            Id = 1,
            Name = "Beauty",
            CssIcon = "fas fa-spa"
        });

        modelBuilder.Entity<Product>().HasData(new Product
        {
            Id = 1,
            Name = "Beauty Kit",
            Description = "A beauty kit by Boticário",
            ImageUrl = "/Images/Beauty/Beauty1.png",
            Price = 100,
            Quantity = 100,
            CategoryId = 1
        });

        modelBuilder.Entity<User>().HasData(new User
        {
            Id = 1,
            Name = "Diego",
        });
    }
}
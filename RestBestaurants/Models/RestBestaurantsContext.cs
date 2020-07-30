using Microsoft.EntityFrameworkCore;

namespace RestBestaurants.Models
{
  public class RestBestaurantsContext : DbContext
  {
    public virtual DbSet<Cuisine> Cuisines { get; set; }
    public DbSet<Restaurant> Restaurants { get; set; }
    
    public RestBestaurantsContext(DbContextOptions options) : base(options) { }
  }
}
using System.Data.Entity;

namespace ReviewSiteData
{
    class ReviewSiteContext : DbContext
    {
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }

        public ReviewSiteContext() : base("name=ReviewSiteContext")
        {
            
        }
    }
}

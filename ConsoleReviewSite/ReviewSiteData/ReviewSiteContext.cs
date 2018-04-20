using System.Data.Entity;
using ReviewSiteData.Base.Model;

namespace ReviewSiteData
{
    public class ReviewSiteContext : DbContext
    {
        public DbSet<Review> Reviews { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }

        public ReviewSiteContext() : base("name=ReviewSiteContext")
        {
            
        }
    }
}
